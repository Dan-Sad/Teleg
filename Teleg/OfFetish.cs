using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfFetish : Query
    {
        public OfFetish(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Fetish;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.FetishAnalSex] = () => _telegram.sqlMes.Add("Role LIKE '%анал%'"),
                [telegram.Button.FetishBukaki] = () => _telegram.sqlMes.Add("signs LIKE '%семяизвержение%'"),
                [telegram.Button.FetishCuni] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%кунилингус%'"),
                [telegram.Button.FetishDoublePenetration] = () => _telegram.sqlMes.Add("(Role LIKE '%пара%' AND [Type of stimulation] LIKE '%анус%')"),
                [telegram.Button.FetishFeelPlenum] = () => _telegram.sqlMes.Add("Role LIKE '%анал%'"),
                [telegram.Button.FetishFillPlace] = () => _telegram.sqlMes.Add("Intelligent Mode LIKE '%да%'"),
                [telegram.Button.FetishPetGame] = () => _telegram.sqlMes.Add("signs LIKE '%PetGame%'"),
                [telegram.Button.FetishPublicPlace] = () => _telegram.sqlMes.Add("Role LIKE '%секрет%'"),
                [telegram.Button.FetishRealistic] = () => _telegram.sqlMes.Add("signs LIKE '%UR3%'"),
                [telegram.Button.FetishSecretGame] = () => _telegram.sqlMes.Add("Role LIKE '%секрет%'"),
                [telegram.Button.FetishIntel] = () => _telegram.sqlMes.Add("[Intelligent Mode] LIKE '%да%'"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
