using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLubricant : Query
    {
        StateNeedOfLubricant stateNeedOfLubricant;
        StateWichOfLubricant stateWichOfLubricant;

        ComandChoose LubricantWater = new ComandChoose() { sqlRequest = "Lubricant LIKE '%водная%'" };
        ComandChoose LubricantSilicon = new ComandChoose() { sqlRequest = "Lubricant LIKE '%силиконовая%'" };
        ComandChoose LubricantOily = new ComandChoose() { sqlRequest = "Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'" };
        ComandChoose LubricantWaterOily = new ComandChoose() { sqlRequest = "Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'" };
        ComandChoose LubricantWaterSilicon = new ComandChoose() { sqlRequest = "Lubricant LIKE '%водно-силиконовая%'" };
        public OfLubricant(TelegConnect telegram) : base(telegram)
        {
            stateNeedOfLubricant = new StateNeedOfLubricant(_telegram);
            stateWichOfLubricant = new StateWichOfLubricant(_telegram);

            questionForUser = telegram.Question.Lubricant;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.LubricantWater] = LubricantWater,
                [telegram.Button.LubricantSilicon] = LubricantSilicon,
                [telegram.Button.LubricantOily] = LubricantOily,
                [telegram.Button.LubricantWaterOily] = LubricantWaterOily,
                [telegram.Button.LubricantWaterSilicon] = LubricantWaterSilicon,
                [telegram.Button.LubricantNoMatters] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = stateNeedOfLubricant },
                [telegram.Button.NotClue] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = stateWichOfLubricant },
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
