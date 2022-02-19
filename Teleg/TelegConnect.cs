using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Teleg
{
    class TelegConnect
    {
        private ChatId _chatID;
        public Query currentQuery { get; set; }
        private MessageEventArgs _messageEvent;
        private CallbackQueryEventArgs _callbackEvent;
        private int _lastMesId;
        public OfMenu ofMenu;
        public bool haveNewMessage { get; set; } = false;
        public bool haveNewCallback { get; set; } = false;

        public List<string> sqlMes = new List<string>();
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ILanguageQuestion Question = new QuestionRUS();
        public ILanguageButton Button = new ButtonRUS();

        public TelegConnect(long chatID, MessageEventArgs eventArg)
        {
            _chatID = chatID;
            _messageEvent = eventArg;
            sqlMes.Add("SELECT name FROM VibroItems");

            ofMenu = new OfMenu(this);
            currentQuery = ofMenu; // CALL MENU
            currentQuery.SendQuery(currentQuery);
        }

        public void TelegConnectRestart()
        {
            DelLastSentMes();
            sqlMes = new List<string>() { "SELECT name FROM VibroItems" };

            ofMenu = new OfMenu(this);
            currentQuery = ofMenu; // CALL MENU
            currentQuery.SendQuery(currentQuery);
        }

        public void PushData(long chatID, MessageEventArgs messageEvent)
        {
            _chatID = chatID;
            _messageEvent = messageEvent;
        }

        public void PushData(CallbackQueryEventArgs callbackEvent)
        {
            _callbackEvent = callbackEvent;
        }

        public string GetMes()
        {
            haveNewMessage = false;
            return _messageEvent.Message.Text;
        }

        public string GetCallback()
        {
            haveNewCallback = false;
            return _callbackEvent.CallbackQuery.Data;
        }

        public void SendMes(string textForSend)
            => Teleg.bot.SendTextMessageAsync(_chatID, textForSend);
        public void SendMes(string textForSend, InlineKeyboardMarkup keyboard)
            => _lastMesId = Teleg.bot.SendTextMessageAsync(_chatID, textForSend, replyMarkup: keyboard).Result.MessageId;

        public void SendQueryOfTeleg(string textForSend, InlineKeyboardMarkup keyboard)
            => Teleg.bot.EditMessageTextAsync(_chatID, _lastMesId, textForSend, replyMarkup: keyboard);

        public void DelLastSentMes()
            => Teleg.bot.DeleteMessageAsync(_chatID, _lastMesId);

        public List<string> CreateCommandSQL(string sqlExpression)
        {
            List<string> resultData = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string currentValue;
                            if ((currentValue = reader.GetValue(0).ToString()) != string.Empty)
                                resultData.Add(currentValue);
                        }
                    }
                }
            }
            return resultData;
        }

        public void CallQuery()
        {
            haveNewCallback = false; 

            currentQuery.buttons[_callbackEvent.CallbackQuery.Data]();
            SendQueryOfTeleg(currentQuery.questionForUser, currentQuery.keyboard);

        }
    }
}
