using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfReusability : Query
    {
        public OfReusability(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Reusability;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.ReusabilityLot] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Reusability LIKE '%да%'")},
                [telegram.Button.ReusabilityOne] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Reusability LIKE '%нет%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuEcology},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
