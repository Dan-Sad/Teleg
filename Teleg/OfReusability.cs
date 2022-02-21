using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfReusability : Query
    {
        ComandChoose ReusabilityLot = new ComandChoose() { sqlRequest = "Reusability LIKE '%да%'" };
        ComandChoose ReusabilityOne = new ComandChoose() { sqlRequest = "Reusability LIKE '%нет%'" };
        public OfReusability(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Reusability;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.ReusabilityLot] = ReusabilityLot,
                [telegram.Button.ReusabilityOne] = ReusabilityOne,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuEcology},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
