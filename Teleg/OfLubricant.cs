using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLubricant : Query
    {
        ComandChoose LibricantWater = new ComandChoose() { sqlRequest = "Lubricant LIKE '%водная%'" };
        ComandChoose LibricantSilicon = new ComandChoose() { sqlRequest = "Lubricant LIKE '%силиконовая%'" };
        ComandChoose LibricantOily = new ComandChoose() { sqlRequest = "Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'" };
        ComandChoose LibricantWaterOily = new ComandChoose() { sqlRequest = "Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'" };
        ComandChoose LibricantWaterSilicon = new ComandChoose() { sqlRequest = "Lubricant LIKE '%водно-силиконовая%'" };
        public OfLubricant(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Lubricant;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.LibricantWater] = LibricantWater,
                [telegram.Button.LibricantSilicon] = LibricantSilicon,
                [telegram.Button.LibricantOily] = LibricantOily,
                [telegram.Button.LibricantWaterOily] = LibricantWaterOily,
                [telegram.Button.LibricantWaterSilicon] = LibricantWaterSilicon,
                [telegram.Button.LibricantNoMatters] = new ComandChoose() { ActionButton = () => Console.WriteLine(questionForUser)},
                [telegram.Button.NotClue] = new ComandChoose() { ActionButton = () => Console.WriteLine(questionForUser)},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
