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
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StealthView] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofStealthView },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu },
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
