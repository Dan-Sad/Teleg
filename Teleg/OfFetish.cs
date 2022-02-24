using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfFetish : Query
    {
        ComandChoose FetishAnalSex = new ComandChoose() { sqlRequest = "Role LIKE '%анал%'" };
        ComandChoose FetishBukaki = new ComandChoose() { sqlRequest = "signs LIKE '%семяизвержение%'" };
        ComandChoose FetishCuni = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%кунилингус%'" };
        ComandChoose FetishDoublePenetration = new ComandChoose() { sqlRequest = "(Role LIKE '%пара%' AND [Type of stimulation] LIKE '%анус%')" };
        ComandChoose FetishFeelPlenum = new ComandChoose() { sqlRequest = "Role LIKE '%анал%'" };
        ComandChoose FetishFillPlace = new ComandChoose() { sqlRequest = "[Intelligent Mode] LIKE '%да%'" };
        ComandChoose FetishPetGame = new ComandChoose() { sqlRequest = "signs LIKE '%PetGame%'" };
        ComandChoose FetishPublicPlace = new ComandChoose() { sqlRequest = "Role LIKE '%секрет%'" };
        ComandChoose FetishRealistic = new ComandChoose() { sqlRequest = "signs LIKE '%UR3%'" };
        ComandChoose FetishSecretGame = new ComandChoose() { sqlRequest = "Role LIKE '%секрет%'" };
        ComandChoose FetishIntel = new ComandChoose() { sqlRequest = "[Intelligent Mode] LIKE '%да%'" };
        public OfFetish(TelegConnect telegram) : base(telegram)
        {
            sqlSeparator = " OR ";

            questionForUser = telegram.Question.Fetish;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.FetishAnalSex] = FetishAnalSex,
                [telegram.Button.FetishBukaki] = FetishBukaki,
                [telegram.Button.FetishCuni] = FetishCuni,
                [telegram.Button.FetishDoublePenetration] = FetishDoublePenetration,
                [telegram.Button.FetishFeelPlenum] = FetishFeelPlenum,
                [telegram.Button.FetishFillPlace] = FetishFillPlace,
                [telegram.Button.FetishPetGame] = FetishPetGame,
                [telegram.Button.FetishPublicPlace] = FetishPublicPlace,
                [telegram.Button.FetishRealistic] = FetishRealistic,
                [telegram.Button.FetishSecretGame] = FetishSecretGame,
                [telegram.Button.FetishIntel] = FetishIntel,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuWishes},
            };

            CreateButtonResullt();
        }
    }
}