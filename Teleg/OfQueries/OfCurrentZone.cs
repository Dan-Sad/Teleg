using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfCurrentZone : Query
    {
        ComandChoose Clitor = new ComandChoose() { sqlRequest = "Aggregation LIKE '%жидкий%'" };
        ComandChoose Vagina = new ComandChoose() { sqlRequest = "Aggregation LIKE '%твердый%'" };
        ComandChoose Anal = new ComandChoose() { sqlRequest = "Aggregation LIKE '%жидкий%'" };
        ComandChoose Combination = new ComandChoose() { sqlRequest = "Aggregation LIKE '%твердый%'" };
        public OfCurrentZone(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.CurrentZone;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Clitor] = Clitor,
                [telegram.Button.Vagina] = Vagina,
                [telegram.Button.Anal] = Anal,
                [telegram.Button.Combination] = Combination,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuZona },
            };

            CreateButtonResult();

            //GenButtons();
        }
    }
}