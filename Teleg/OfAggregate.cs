using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfAggregate : Query
    {
        ComandChoose AgregateLiquid = new ComandChoose() { sqlRequest = "Aggregation LIKE '%жидкий%'" };
        ComandChoose AgregateHard = new ComandChoose() { sqlRequest = "Aggregation LIKE '%твердый%'" };
        public OfAggregate(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Agregate;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.AgregateLiquid] = AgregateLiquid,
                [telegram.Button.AgregateHard] = AgregateHard,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic },
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
