using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace Teleg
{
    delegate void Method();
    abstract class Query
    {
        public TelegConnect _telegram;
        public string questionForUser { get; set; }
        public Dictionary<string, ComandChoose> buttons;
        public InlineKeyboardMarkup keyboard;

        public Query(TelegConnect telegram) => _telegram = telegram;

        public void CreateButtonResullt()
        {
            buttons.Add(_telegram.Button.Result, new ComandChoose()
            {
                ActionButton = () =>
                {
                    List<string> resultData = _telegram.GetDataOfSQL(GenerateSqlMessange(forCount: false));

                    foreach (string currentData in resultData)
                    {
                        _telegram.SendMes("*" + currentData + "*");
                        Thread.Sleep(100);
                    }

                    Thread.Sleep(1000);
                    _telegram.TelegConnectRestart();
                }
            });
        }

        private string GenerateSqlMessange(bool forCount)
        {
            string sqlMessange;

            if (forCount)
                sqlMessange = "SELECT COUNT(name)";
            else
                sqlMessange = "SELECT name";

            sqlMessange += " FROM VibroItems";

            if (_telegram.sqlMes.Count > 1)
            {
                sqlMessange += " WHERE " + String.Join("", _telegram.sqlMes.ToArray(), 0, 1);
                sqlMessange += " AND " + String.Join(" AND ", _telegram.sqlMes.ToArray(), 1, _telegram.sqlMes.Count - 1);
            }
            else if (_telegram.sqlMes.Count > 0)
            {
                sqlMessange += " WHERE " + String.Join("", _telegram.sqlMes.ToArray(), 0, 1);
            }

            return sqlMessange;
        }

        public void BaseRealizing()
        {
            keyboard = GenKeyboardButtons();
        }

        public virtual InlineKeyboardMarkup GenKeyboardButtons()
        {
            var rows = new List<InlineKeyboardButton[]>();
            var cols = new List<InlineKeyboardButton>();
            int countButtonsOnRows = 0;

            foreach (KeyValuePair<string, ComandChoose> button in buttons)
            {
                bool choosen = button.Value.Chosen;
                string textButton = button.Key;
                string dataButton = button.Key;

                if (choosen)
                    textButton = textButton.Insert(0, char.ConvertFromUtf32(0x2714));

                if (dataButton == _telegram.Button.Result)
                {
                    textButton += " (" + _telegram.GetCountDataSQL(GenerateSqlMessange(forCount: true)) + ")";
                }

                cols.Add(new InlineKeyboardButton() { CallbackData = dataButton, Text = textButton });
                
                countButtonsOnRows++;

                //Средняя длина тектса кнопки
                if (textButton.Length > 9 && textButton.Length <= 16) 
                {
                    countButtonsOnRows = 0;
                    if (countButtonsOnRows % 2 == 0)
                    {
                        rows.Add(cols.ToArray());
                        cols = new List<InlineKeyboardButton>();
                    }else if(countButtonsOnRows % 3 == 0)
                    {
                        cols = new List<InlineKeyboardButton>();
                        cols.Add(new InlineKeyboardButton() { CallbackData = dataButton, Text = textButton });
                        rows.Add(cols.ToArray());
                    }
                }

                //Длинный текст кнопки
                if (textButton.Length > 16) 
                {
                    countButtonsOnRows = 0;
                    rows.Add(cols.ToArray());
                    cols = new List<InlineKeyboardButton>();
                }

                //Короткий тектс кнопки
                if (countButtonsOnRows % 3 == 0)
                {
                    countButtonsOnRows = 0;
                    rows.Add(cols.ToArray());
                    cols = new List<InlineKeyboardButton>();
                }
            }

            rows.Add(cols.ToArray());
            return new InlineKeyboardMarkup(rows.ToArray());
        }

        public async void SendQuery(Query OfQuestion)
        {
            _telegram.currentQuery = OfQuestion;

            _telegram.SendMes(OfQuestion.questionForUser, OfQuestion.keyboard);

            await Task.Run(() => { while (!_telegram.haveNewCallback) Thread.Sleep(100); });

            var button = OfQuestion.buttons[_telegram.GetCallback()];

            if (button.sqlRequest != null)
                button.SqlPushOrDell(_telegram);
            else
                button.ActionButton();
        } 
    }
}
