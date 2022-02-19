using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfAggregate : Query
    {
        public OfAggregate(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Agregate;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.AgregateLiquid] = () => _telegram.sqlMes.Add("Aggregation LIKE '%жидкий%'"),
                [telegram.Button.AgregateHard] = () => _telegram.sqlMes.Add("Aggregation LIKE '%твердый%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic,
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
