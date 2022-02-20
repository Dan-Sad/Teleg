using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuSates : Query
    {
        public MenuSates(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.States;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StateNeedOfLubricant] = new ComandChoose() { ActionButton = () => Console.WriteLine(questionForUser) },
                [telegram.Button.StateWichOfLubricant] = new ComandChoose() { ActionButton = () => Console.WriteLine(questionForUser) },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu },
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
