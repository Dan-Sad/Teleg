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
        public Dictionary<string, Method> buttons;
        public ReplyKeyboardMarkup keyboard;

        public Method _prevQuery, _nextQuery;
        public Query _lastCalledQuery;
        public bool multipleCall { get; set; } = false;

        private bool firstEntryQuery = true;
        public int _countCalledButtons = 0;
        public int _countCalledButtonsPrevQuery;

        public Query(TelegConnect telegram) => _telegram = telegram;
        public Query(TelegConnect telegram, Query callerQuery, int countCalledButtons)
        {
            _countCalledButtonsPrevQuery = countCalledButtons;
            _telegram = telegram;
            _lastCalledQuery = callerQuery;
        }

        public void SpecificRealizing()
        {
            _prevQuery = () =>
            {
                List<string> sqlMes = _telegram.sqlMes;
                int countDeletingButtons = _countCalledButtons + _countCalledButtonsPrevQuery;
                sqlMes.RemoveRange(sqlMes.Count - countDeletingButtons, countDeletingButtons);
                PushQuery(_lastCalledQuery);
            };

            buttons.Add(_telegram.Button.Return, _prevQuery);

            
            buttons.Add(_telegram.Button.Result, () => {
                string sqlMessange = String.Join(" WHERE ", _telegram.sqlMes.ToArray(), 0, 2);
                sqlMessange += " AND " + String.Join(" AND ", _telegram.sqlMes.ToArray(), 2, _telegram.sqlMes.Count - 2);
                List<string> resultData = _telegram.CreateCommandSQL(sqlMessange);
                foreach (string currentData in resultData)
                {
                    _telegram.SendMes(currentData);
                    Thread.Sleep(100);
                }
            });
        }

        public void BaseRealizing()
        {
            buttons.Add(_telegram.Button.Next, _nextQuery);

            keyboard = GenKeyboardButtons();
        }

        public virtual ReplyKeyboardMarkup GenKeyboardButtons()
        {
            var rows = new List<KeyboardButton[]>();
            var cols = new List<KeyboardButton>();
            int countGeneratedButtons = 0, countButtonsOnRows = 0;

            foreach (var nameButton in buttons.Keys)
            {
                cols.Add(new KeyboardButton(nameButton));
                countButtonsOnRows++;

                if (buttons.Count - ++countGeneratedButtons <= 3)
                {
                    if (buttons.Count - countGeneratedButtons == 3)
                    {
                        rows.Add(cols.ToArray());
                        cols = new List<KeyboardButton>();
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
                        cols = new List<KeyboardButton>();
                    }else if(countButtonsOnRows % 3 == 0)
                    {
                        cols = new List<KeyboardButton>();
                        cols.Add(new KeyboardButton(nameButton));
                        rows.Add(cols.ToArray());
                    }
                }

                //Длинный текст кнопки
                if (nameButton.Length > 16) 
                {
                    countButtonsOnRows = 0;
                    rows.Add(cols.ToArray());
                    cols = new List<KeyboardButton>();
                }

                //Короткий тектс кнопки
                if (countButtonsOnRows % 3 == 0)
                {
                    countButtonsOnRows = 0;
                    rows.Add(cols.ToArray());
                    cols = new List<KeyboardButton>();
                }
            }

            rows.Add(cols.ToArray());
            return new ReplyKeyboardMarkup() { Keyboard = rows.ToArray() };
        }

        public async void PushQuery(Query OfQuestion)
        {
            _countCalledButtons++;

            if (firstEntryQuery)
                _telegram.SendMes(OfQuestion.questionForUser, OfQuestion.keyboard);
            else
                _telegram.SendMes(_telegram.Question.ChooseMore, OfQuestion.keyboard);

            await Task.Run(() => { while (!_telegram.haveNewMessage) Thread.Sleep(10); });

            string Message = _telegram.GetMes();

            foreach (var buttonMessage in OfQuestion.buttons.Keys)
            {
                if (Message == buttonMessage)
                {
                    MessageIsButtonMes(Message, OfQuestion);
                    return;
                }
            }

            _telegram.SendMes(_telegram.Button.ChoseOfRecomennd);
            PushQuery(OfQuestion);
        } 

        private void MessageIsButtonMes(string Message, Query OfQuestion)
        {
            if (Message == _telegram.Button.Next || Message == _telegram.Button.Return || Message == _telegram.Button.Result)
            {
                firstEntryQuery = true;
                OfQuestion.buttons[Message]();
                return;
            }

            OfQuestion._countCalledButtons++;
            OfQuestion.buttons[Message]();

            if (OfQuestion.multipleCall)
            {
                firstEntryQuery = false;
                OfQuestion.buttons.Remove(Message);
                OfQuestion.keyboard = OfQuestion.GenKeyboardButtons();
                PushQuery(OfQuestion);
            }
            else
            {
                firstEntryQuery = true;
                OfQuestion._nextQuery();
            }
        }
    }
}
