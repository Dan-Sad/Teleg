using System;
using System.Collections.Generic;

namespace Teleg
{
    class OfAllergy : Query
    {
        public OfAllergy(TelegConnect telegram, Query callerQuery, int countCalledButtons) : base(telegram, callerQuery, countCalledButtons)
        {
            questionForUser = telegram.Question.Allergy;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.AllergySilikon] = () => _telegram.sqlMes.Add("Material NOT LIKE '%силикон%'"),
                [telegram.Button.AllergyLatex] = () => _telegram.sqlMes.Add("Material NOT LIKE '%латекс%'"),
                [telegram.Button.AllergyBioSkin] = () => _telegram.sqlMes.Add("Material NOT LIKE '%Bioskin%'"),
                [telegram.Button.AllergyTPR] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.AllergyABS_plastic] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.NotClue] = () => Console.WriteLine($"ToDo {questionForUser}"),
            };
            _nextQuery = () => PushQuery(new OfLubricant(telegram, new OfAllergy(telegram, callerQuery, countCalledButtons), _countCalledButtons));

            multipleCall = true;
            SpecificRealizing();

            BaseRealizing();
        }
    }
}
