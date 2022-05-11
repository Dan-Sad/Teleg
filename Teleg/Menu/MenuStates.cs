using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStates : Query
    {
        public MenuStates(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.States;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            buttonsURL = new Dictionary<string, string>()
            {
                [telegram.Button.StateNeedOfLubricant] = "https://t.me/who_if_not_hand/5",
                [telegram.Button.StateWichOfLubricant] = "https://t.me/who_if_not_hand/7",
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}
