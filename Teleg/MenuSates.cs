using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuSates : Query
    {
        OfMenu ofMenu;
        public MenuSates(TelegConnect telegram) : base(telegram)
        {
            ofMenu = new OfMenu(telegram);
            questionForUser = telegram.Question.States;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StateNeedOfLubricant] = () => Console.WriteLine(questionForUser),
                [telegram.Button.StateWichOfLubricant] = () => Console.WriteLine(questionForUser),
                [telegram.Button.Apply] = () => _telegram.currentQuery = ofMenu,
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
