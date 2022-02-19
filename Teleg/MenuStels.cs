using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStels : Query
    {
        OfStealthView ofStealthView;

        public MenuStels(TelegConnect telegram) : base(telegram)
        {
            ofStealthView = new OfStealthView(telegram); 

            questionForUser = telegram.Question.Stels;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StealthView] = () => _telegram.currentQuery = ofStealthView,
                [telegram.Button.Apply] = () => _telegram.currentQuery = _telegram.ofMenu,
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
