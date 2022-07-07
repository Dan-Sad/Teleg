using System;
using System.Collections.Generic;

namespace Teleg
{
    class OfAllergy : Query
    {
        ComandChoose AllergySilikon = new ComandChoose() { sqlRequest = "Material NOT LIKE '%силикон%'" };
        ComandChoose AllergyLatex = new ComandChoose() { sqlRequest = "Material NOT LIKE '%латекс%'" };
        ComandChoose AllergyBioSkin = new ComandChoose() { sqlRequest = "Material NOT LIKE '%Bioskin%'" };
        ComandChoose AllergyTPR = new ComandChoose() { sqlRequest = "Material NOT LIKE '%TPR%'" };
        ComandChoose AllergyABS_plastic = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
        public OfAllergy(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Allergy;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.AllergySilikon] = AllergySilikon,
                [telegram.Button.AllergyLatex] = AllergyLatex,
                [telegram.Button.AllergyBioSkin] = AllergyBioSkin,
                [telegram.Button.AllergyTPR] = AllergyTPR,
                [telegram.Button.AllergyABS_plastic] = AllergyABS_plastic,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuCharacteristic },
            };

            CreateButtonResult();
        }
    }
}
