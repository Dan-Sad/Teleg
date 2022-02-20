using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLubricant : Query
    {
        public OfLubricant(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Lubricant;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.LibricantWater] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Lubricant LIKE '%водная%'")},
                [telegram.Button.LibricantSilicon] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Lubricant LIKE '%силиконовая%'")},
                [telegram.Button.LibricantOily] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'")},
                [telegram.Button.LibricantWaterOily] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'")},
                [telegram.Button.LibricantWaterSilicon] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Lubricant LIKE '%водно-силиконовая%'")},
                [telegram.Button.LibricantNoMatters] = new ComandChoose() { ActionButton = () => Console.WriteLine(questionForUser)},
                [telegram.Button.NotClue] = new ComandChoose() { ActionButton = () => Console.WriteLine(questionForUser)},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
