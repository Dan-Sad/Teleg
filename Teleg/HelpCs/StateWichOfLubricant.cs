using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class StateWichOfLubricant : Query
    {
        public StateWichOfLubricant(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.StateWichOfLubricant;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Return] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Menu] },
            };

            buttonsURL = new Dictionary<string, string>()
            {
                [telegram.Button.State] = "https://t.me/who_if_not_hand/7",
            };

            GenButtons();
        }
    }
}
