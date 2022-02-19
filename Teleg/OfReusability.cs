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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.ReusabilityLot] = () => _telegram.sqlMes.Add("Reusability LIKE '%да%'"),
                [telegram.Button.ReusabilityOne] = () => _telegram.sqlMes.Add("Reusability LIKE '%нет%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = _telegram.ofMenu.menuEcology,
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
