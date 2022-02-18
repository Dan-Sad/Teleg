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
        private long _chatID;
        private MessageEventArgs _eventArg;
        private Message _lastMessage;
        public bool haveNewMessage { get; set; } = false;
        public List<string> sqlMes = new List<string>();

        public ILanguageQuestion Question = new QuestionENG();
        public ILanguageButton Button = new ButtonENG();
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public TelegConnect(long chatID, MessageEventArgs eventArg)
        {
            _chatID = chatID;
            _eventArg = eventArg;
            sqlMes.Add("SELECT name FROM VibroItems");/*SELECT name FROM VibroItems*/

            var language = new OfLanguage(this);
            language.PushQuery(language);
        }

        public void DelLastSentMes()
            => Teleg.bot.DeleteMessageAsync(_eventArg.Message.Chat.Id, _lastMessage.MessageId);

        public void PushDate(long chatID, MessageEventArgs eventArg)
        {
            _chatID = chatID;
            _eventArg = eventArg;
        }

        public string GetMes()
        {
            haveNewMessage = false;
            return _eventArg.Message.Text;
        }

        public void SendMes(string textForSend)
            => _lastMessage = Teleg.bot.SendTextMessageAsync(_chatID, textForSend).Result;


        public void SendMes(string textForSend, ReplyKeyboardMarkup keyboard)
            => _lastMessage = Teleg.bot.SendTextMessageAsync(_chatID, textForSend, replyMarkup: keyboard).Result;


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
    }
}
