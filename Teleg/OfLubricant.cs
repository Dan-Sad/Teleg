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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.LibricantWater] = () => _telegram.sqlMes.Add("Lubricant LIKE '%водная%'"),
                [telegram.Button.LibricantSilicon] = () => _telegram.sqlMes.Add("Lubricant LIKE '%силиконовая%'"),
                [telegram.Button.LibricantOily] = () => _telegram.sqlMes.Add("Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'"),
                [telegram.Button.LibricantWaterOily] = () => _telegram.sqlMes.Add("Lubricant LIKE '%масляная%' AND Lubricant LIKE '%водно-масляная%'"),
                [telegram.Button.LibricantWaterSilicon] = () => _telegram.sqlMes.Add("Lubricant LIKE '%водно-силиконовая%'"),
                [telegram.Button.LibricantNoMatters] = () => Console.WriteLine(questionForUser),
                [telegram.Button.NotClue] = () => Console.WriteLine(questionForUser),
                [telegram.Button.Ready] = () => _telegram.currentQuery = _telegram.ofMenu.menuCharacteristic,
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
