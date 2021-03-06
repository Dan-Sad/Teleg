using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class StateNeedOfLubricant : Query
    {
        public StateNeedOfLubricant(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.StateNeedOfLubricant;

            buttons = new Dictionary<string, ComandChoose>()
            {
                
                [telegram.Button.Return] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Menu] },
            };

            buttonsURL = new Dictionary<string, string>()
            {
                [telegram.Button.State] = "https://t.me/who_if_not_hand/5",
            };

            GenButtons();
        }
    }
}
