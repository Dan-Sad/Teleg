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
        public Dictionary<string, Button> buttons;
        public InlineKeyboardMarkup keyboard;
        public bool multipleCall { get; set; } = false;

        public Query(TelegConnect telegram) => _telegram = telegram;

        public void CreateButtonResullt()
        {
            Button button = new Button() { ActionMethod = () => Console.WriteLine("") };
            buttons.Add(questionForUser, new Button() { ActionMethod = () => Console.WriteLine("") });
            buttons.Add(_telegram.Button.Result, new Button()
            {
                ActionMethod = () =>
                {

                    string sqlMessange;

                    if (_telegram.sqlMes.Count > 2)
                    {
                        sqlMessange = String.Join(" WHERE ", _telegram.sqlMes.ToArray(), 0, 2);
                        sqlMessange += " AND " + String.Join(" AND ", _telegram.sqlMes.ToArray(), 2, _telegram.sqlMes.Count - 2);
                    }
                    else if (_telegram.sqlMes.Count > 1)
                    {
                        sqlMessange = String.Join(" WHERE ", _telegram.sqlMes.ToArray(), 0, 2);
                    }
                    else
                    {
                        sqlMessange = String.Join("", _telegram.sqlMes.ToArray());
                    }

                    List<string> resultData = _telegram.CreateCommandSQL(sqlMessange);

                    foreach (string currentData in resultData)
                    {
                        _telegram.SendMes(currentData);
                    }

                    Thread.Sleep(3000);
                    _telegram.TelegConnectRestart();
                }
            });
        }

        public void BaseRealizing()
        {

            keyboard = GenKeyboardButtons();
        }

        public virtual InlineKeyboardMarkup GenKeyboardButtons()
        {
            var rows = new List<InlineKeyboardButton[]>();
            var cols = new List<InlineKeyboardButton>();
            int countGeneratedButtons = 0, countButtonsOnRows = 0;

            foreach (var nameButton in buttons.Keys)
            {
                cols.Add(new InlineKeyboardButton() { CallbackData = nameButton, Text = nameButton });
                countButtonsOnRows++;

                if (buttons.Count - ++countGeneratedButtons <= 3)
                {
                    if (buttons.Count - countGeneratedButtons == 3)
                    {
                        rows.Add(cols.ToArray());
                        cols = new List<InlineKeyboardButton>();
                    }
                    continue;
                }

                //Средняя длина тектса кнопки
                if (nameButton.Length > 9 && nameButton.Length <= 16) 
                {
                    countButtonsOnRows = 0;
                    if (countButtonsOnRows % 2 == 0)
                    {
                        rows.Add(cols.ToArray());
                        cols = new List<InlineKeyboardButton>();
                    }else if(countButtonsOnRows % 3 == 0)
                    {
                        cols = new List<InlineKeyboardButton>();
                        cols.Add(new InlineKeyboardButton() { CallbackData = nameButton, Text = nameButton });
                        rows.Add(cols.ToArray());
                    }
                }

                //Длинный текст кнопки
                if (nameButton.Length > 16) 
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

            await Task.Run(() => { while (!_telegram.haveNewCallback) Thread.Sleep(10); });

            OfQuestion.buttons[_telegram.GetCallback()]();
        } 
    }
}
