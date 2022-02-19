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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StateNeedOfLubricant] = () => Console.WriteLine(questionForUser),
                [telegram.Button.StateWichOfLubricant] = () => Console.WriteLine(questionForUser),
                [telegram.Button.Apply] = () => _telegram.currentQuery = _telegram.ofMenu,
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
