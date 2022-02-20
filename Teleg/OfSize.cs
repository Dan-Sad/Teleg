using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfSize : Query
    {
        public OfSize(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.SizeOfHand;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.S] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("([Size of hand] < 7 )")},
                [telegram.Button.M] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("([Size of hand] >= 7 AND [Size of hand] <= 12)")},
                [telegram.Button.L] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("([Size of hand] >= 13)")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
