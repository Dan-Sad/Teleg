using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfSize : Query
    {
        ComandChoose S = new ComandChoose() { sqlRequest = "([Size of hand] < 7 )" };
        ComandChoose M = new ComandChoose() { sqlRequest = "([Size of hand] >= 7 AND [Size of hand] <= 12)" };
        ComandChoose L = new ComandChoose() { sqlRequest = "([Size of hand] >= 13)" };
        public OfSize(TelegConnect telegram) : base(telegram)
        {
            sqlSeparator = " OR ";

            Question = telegram.Question.SizeOfHand;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.S] = S,
                [telegram.Button.M] = M,
                [telegram.Button.L] = L,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuCharacteristic},
            };

            CreateButtonResult();
        }
    }
}
