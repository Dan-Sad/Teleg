using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfStealthView : Query
    {
        ComandChoose StealthViewNoMatters = new ComandChoose() { sqlRequest = "[stealth view] LIKE '%нет%'" };
        ComandChoose StealthViewMatters = new ComandChoose() { sqlRequest = "[stealth view] LIKE '%да%'" };
        public OfStealthView(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.StealthView;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StealthViewNoMatters] = StealthViewNoMatters,
                [telegram.Button.StealthViewMatters] = StealthViewMatters,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuStels},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
