using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Teleg
{
    class TelegConnect
    {
        private ChatId _chatID;
        public LastMessange LastMes = new LastMessange();
        private MessageEventArgs _messageEvent;
        private CallbackQueryEventArgs _callbackEvent;
        public bool haveNewMessage { get; set; } = false;
        public bool haveNewCallback { get; set; } = false;

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ILanguageQuestion Question = new QuestionRUS();
        public ILanguageButton Button = new ButtonRUS();

        public Query currentQuery { get; set; }
        public Menu Menu;
        public Dictionary<string, Query> queries;
        public ResultAction resultAction;

        public TelegConnect(long chatID, MessageEventArgs eventArg)
        {
            _chatID = chatID;
            _messageEvent = eventArg;

            QuerysInit();

            //currentQuery = new Language(this);
            //currentQuery.SendQuery(currentQuery);

            currentQuery = Menu = new Menu(this);
            Menu.SendQuery(Menu);
        }

        public void TelegConnectRestart()
        {
            queries.Clear();
            QuerysInit();
            currentQuery = Menu;
        }

        public void PushData(long chatID, MessageEventArgs messageEvent)
        {
            _chatID = chatID;
            _messageEvent = messageEvent;
        }

        public void PushData(CallbackQueryEventArgs callbackEvent) => _callbackEvent = callbackEvent;

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

        public async void SendMesAsync(string textForSend)
            =>  await Teleg.bot.SendTextMessageAsync(_chatID, textForSend, parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);

        public async void SendMesAsync(string textForSend, InlineKeyboardMarkup keyboard)
        {
            var lastMes = await Teleg.bot.SendTextMessageAsync(_chatID, textForSend, replyMarkup: keyboard, parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
            LastMes.ID = lastMes.MessageId;
            LastMes.Type.Text();
        }

        public async void SendPhotoAsync(byte[] bytesPhoto, string textForSend, InlineKeyboardMarkup keyboard)
        {
            await using (var photo = new MemoryStream(bytesPhoto))
            {
                var lastMes = await Teleg.bot.SendPhotoAsync(_chatID, new InputOnlineFile(photo, "image.png"), caption: textForSend, replyMarkup: keyboard, parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
                LastMes.ID = lastMes.MessageId;
                LastMes.Type.Photo();
            }
        }
        public void EditQueryOfTeleg(string textForSend, InlineKeyboardMarkup keyboard)
            =>  Teleg.bot.EditMessageTextAsync(_chatID, LastMes.ID, textForSend, replyMarkup: keyboard);

        public void DelLastSentMes()
            => Teleg.bot.DeleteMessageAsync(_chatID, LastMes.ID);

        public List<DataSQL> GetDataOfSQL(string sqlExpression)
        {
            var resultData = new List<DataSQL>();

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
                            var currentData = new DataSQL();
                            string currentValue;

                            if ((currentValue = reader.GetValue(0).ToString()) != string.Empty)
                            {
                                currentData.Name = currentValue;

                                if ((currentValue = reader.GetValue(1).ToString()) != string.Empty)
                                    currentData.Description = currentValue;

                                var picture = reader.GetValue(2);

                                if (picture != System.DBNull.Value)
                                    currentData.Picture = (byte[])picture;

                                resultData.Add(currentData);
                            }
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

        public async void CallQuery()
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
                        await Task.Run(() => button.ActionButton());

                    currentQuery.GenButtons();
                    EditQueryOfTeleg(currentQuery.questionForUser, currentQuery.keyboard);
                    return;
                }
            }
        }

        public void DelAndSendQuery()
        {
            DelLastSentMes();
            SendMesAsync(currentQuery.questionForUser, currentQuery.keyboard);
        }

        public void SendQuery() => SendMesAsync(currentQuery.questionForUser, currentQuery.keyboard);

        private void QuerysInit()
        {
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
        }
    }
}
