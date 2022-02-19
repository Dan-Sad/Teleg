using System;
using System.Collections.Generic;

namespace Teleg
{
    class OfAllergy : Query
    {
        MenuCharacteristic menuCharacteristic;
        public OfAllergy(TelegConnect telegram) : base(telegram)
        {
            menuCharacteristic = new MenuCharacteristic(telegram);

            questionForUser = telegram.Question.Allergy;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.AllergySilikon] = () => _telegram.sqlMes.Add("Material NOT LIKE '%силикон%'"),
                [telegram.Button.AllergyLatex] = () => _telegram.sqlMes.Add("Material NOT LIKE '%латекс%'"),
                [telegram.Button.AllergyBioSkin] = () => _telegram.sqlMes.Add("Material NOT LIKE '%Bioskin%'"),
                [telegram.Button.AllergyTPR] = () => _telegram.sqlMes.Add("Material NOT LIKE '%TPR%'"),
                [telegram.Button.AllergyABS_plastic] = () => _telegram.sqlMes.Add("Material NOT LIKE '%ABS%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = menuCharacteristic,
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
