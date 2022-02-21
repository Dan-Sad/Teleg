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
        public Menu Menu;
        public bool haveNewMessage { get; set; } = false;
        public bool haveNewCallback { get; set; } = false;

        public List<string> sqlMes = new List<string>();
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ILanguageQuestion Question = new QuestionRUS();
        public ILanguageButton Button = new ButtonRUS();

        public Dictionary<string, Query> queries;

        public TelegConnect(long chatID, MessageEventArgs eventArg)
        {
            _chatID = chatID;
            _messageEvent = eventArg;

            currentQuery = new Language(this);
            queries = new Dictionary<string, Query>()
            {
                [Question.Agregate] = new OfAggregate(this),
                [Question.Allergy] = new OfAllergy(this),
                [Question.Couple] = new OfCouple(this),
                [Question.Fetish] = new OfFetish(this),
                [Question.Location] = new OfLocation(this),
                [Question.Lubricant] = new OfLubricant(this),
                [Question.Reusability] = new OfReusability(this),
                [Question.Role] = new OfRole(this),
                [Question.Sensation] = new OfSensation(this),
                [Question.SizeOfHand] = new OfSize(this),
                [Question.StealthView] = new OfStealthView(this),
                [Question.TechniqueOfFap] = new OfTechniqueOfFap(this),
                [Question.Stimulation] = new OfTypeSimulation(this),
                [Question.Where] = new OfWhere(this),
            };
            currentQuery.SendQuery(currentQuery);
        }

        public void TelegConnectRestart()
        {
            DelLastSentMes();
            sqlMes = new List<string>();

            Menu = new Menu(this);
            currentQuery = Menu; // CALL MENU
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

        public  void SendMes(string textForSend)
            =>  Teleg.bot.SendTextMessageAsync(_chatID, textForSend, parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        public void SendMes(string textForSend, InlineKeyboardMarkup keyboard)
            => _lastMesId = Teleg.bot.SendTextMessageAsync(_chatID, textForSend, replyMarkup: keyboard).Result.MessageId;

        public void EditQueryOfTeleg(string textForSend, InlineKeyboardMarkup keyboard)
            => Teleg.bot.EditMessageTextAsync(_chatID, _lastMesId, textForSend, replyMarkup: keyboard);

        public void DelLastSentMes()
            => Teleg.bot.DeleteMessageAsync(_chatID, _lastMesId);

        public List<string> GetDataOfSQL(string sqlExpression)
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

        public int GetCountDataSQL(string sqlExpression)
        {
            int resultCount;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Connection.Open();
                resultCount = (int)command.ExecuteScalar();
            }
            return resultCount;
        }

        public void CallQuery()
        {
            haveNewCallback = false;

            foreach (var buttonName in currentQuery.buttons.Keys)
            {
                if (_callbackEvent.CallbackQuery.Data == buttonName)
                {
                    var button = currentQuery.buttons[_callbackEvent.CallbackQuery.Data];

                    if (button.sqlRequest != null)
                        button.SqlPushOrDell(currentQuery.sqlString);
                    else
                        button.ActionButton();

                    currentQuery.GenButtons();
                    EditQueryOfTeleg(currentQuery.questionForUser, currentQuery.keyboard);
                    return;
                }
            }
        }

        public void SendQuery()
        {
            DelLastSentMes();
            SendMes(currentQuery.questionForUser, currentQuery.keyboard);
        }
    }
}
