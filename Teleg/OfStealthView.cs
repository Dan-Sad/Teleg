using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfStealthView : Query
    {
        public OfStealthView(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.StealthView;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StealthViewNoMatters] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[stealth view] LIKE '%нет%'")},
                [telegram.Button.StealthViewMatters] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[stealth view] LIKE '%да%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuStels},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
