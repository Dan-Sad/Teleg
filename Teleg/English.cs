using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class QuestionENG : ILanguageQuestion
    {
        public string Menu { get; } = "Hi!Choose";
        public string ChooseMore { get; } = "You can choose more or click 'Next'";
        public string Language { get; } = "Choose your language";
        public string Allergy { get; } = "Allergy?";
        public string Lubricant { get; }
        public string StateNeedOfLubricant { get; }
        public string StateWichOfLubricant { get; }
        public string Role { get; }
        public string Agregate { get; }
        public string Where { get; }
        public string Fetish { get; }
        public string Location { get; }
        public string Controle { get; }
        public string Reusability { get; }
        public string StealthView { get; }
        public string SizeOfHand { get; }
        public string Sensation { get; }
        public string Stimulation { get; }
        public string TechniqueOfFap { get; }

        //For MenuENG
        public string Characteristic { get; } = "Настрой базовые характеристики";
        public string Ecology { get; } = "Сведения об экологичности";
        public string Stels { get; } = "Важно сохранить в секрете";
        public string Feeling { get; } = "Какие ощущения хочешь испытать";
        public string Wishes { get; } = "Можем осуществить несколько желаний";
        public string States { get; } = "Здесь найдешь полезные статьи";

        public string Couple => throw new NotImplementedException();
    }

    class ButtonENG : ILanguageButton
    {
        public string Apply { get; } = "Apply";
        public string Ready { get; } = "Ready";
        public string Result { get; } = "Result";
        public string LanguageRUS { get; } = "RUS";
        public string LanguageENG { get; } = "ENG";
        public string Return { get; } = "Return";
        public string NotClue { get; } = "Not clue";
        public string ChoseOfRecomennd { get; } = "Use buttons";
        public string Next { get; } = "Next";
        public string NoMatters { get; }
        public string AllergySilikon { get; }
        public string AllergyLatex { get; }
        public string AllergyBioSkin { get; }
        public string AllergyTPR { get; }
        public string AllergyABS_plastic { get; }
        public string LibricantWater { get; }
        public string LibricantSilicon { get; }
        public string LibricantOily { get; }
        public string LibricantWaterSilicon { get; }
        public string LibricantWaterOily { get; }
        public string LibricantNoMatters { get; }
        public string RoleForSelf { get; }
        public string RoleForCouples { get; }
        public string RoleForSecret { get; }
        public string RoleForDouble { get; }
        public string AgregateLiquid { get; }
        public string AgregateHard { get; }
        public string LocationBed { get; }
        public string LocationBath { get; }
        public string LocationShower { get; }
        public string LocationSea { get; }
        public string LocationPool { get; }
        public string FetishPublicPlace { get; }
        public string FetishDoublePenetration { get; }
        public string FetishGameWithPartner { get; }
        public string FetishDistantPartner { get; }
        public string FetishPetGame { get; }
        public string FetishAnalSex { get; }
        public string FetishFeelPlenum { get; }
        public string FetishSecretGame { get; }
        public string FetishRealistic { get; }
        public string FetishBukaki { get; }
        public string FetishBDSM { get; }
        public string FetishIntel { get; }
        public string FetishCuni { get; }
        public string FetishFillPlace { get; }
        public string StimulationVacuum { get; }
        public string StimulationWave { get; }
        public string StimulationVagina { get; }
        public string StimulationClitor { get; }
        public string StimulationMechanical { get; }
        public string StimulationRotation { get; }
        public string StimulationAnus { get; }
        public string ControleManual { get; }
        public string ControleButton { get; }
        public string ControleApp { get; }
        public string ControleConsole { get; }
        public string ReusabilityLot { get; }
        public string ReusabilityOne { get; }
        public string StealthViewNoMatters { get; }
        public string StealthViewMatters { get; }
        public string S { get; }
        public string M { get; }
        public string L { get; }
        public string SensationSoft { get; }
        public string SensationHard { get; }
        public string SensationCold { get; }
        public string SensationMyTemperature { get; }
        public string SensationSmoothness { get; }
        public string SensationVelvety { get; }
        public string SensationRealistic { get; }
        public string WhereClitor { get; }
        public string WhereVagina { get; }
        public string WhereAnus { get; }
        public string WhereClitorVagina { get; }
        public string WhereOtherPoint { get; }
        public string TechniqueOfFapMost { get; }
        public string TechniqueOfFapRabbimg { get; }
        public string TechniqueOfFapClitoris { get; }
        public string TechniqueOfFapAnus { get; }
        public string TechniqueOfFapVagPenet { get; }
        public string TechniqueOfFapTemp { get; }
        public string TechniqueOfFapHlopClitor { get; }
        public string TechniqueOfFapRoundVulva { get; }
        //For Question (Menu)
        public string Agregate { get; } = "Вид игрушки";
        public string Allergy { get; } = "Аллергии";
        public string Couple { get; } = "Для чего парная игрушка";
        public string Fetish { get; } = "Желания";
        public string Location { get; } = "Место";
        public string Lubricant { get; } = "Лубрикант";
        public string Reusability { get; } = "Многоразовость";
        public string Role { get; } = "Роль";
        public string Sensation { get; } = "Ощущения";
        public string SizeOfHand { get; } = "Размер";
        public string StateNeedOfLubricant { get; } = "Зачем нужен лубрикант?";
        public string StateWichOfLubricant { get; } = "Какой мне взять лубрикант?";
        public string StealthView { get; } = "Внешний вид";
        public string Stimulation { get; } = "Тип стимуляции";
        public string TechniqueOfFap { get; } = "Тип мастурбации";
        public string Where { get; } = "Зоны использования";

        //For menu
        public string Characteristic { get; } = "Характеристики";
        public string Ecology { get; } = "Экологичность";
        public string Stels { get; } = "Маскировка";
        public string Feeling { get; } = "Чувствование";
        public string Wishes { get; } = "Желания";
        public string States { get; } = "Статьи";

        public string CoupleStopPenis => throw new NotImplementedException();

        public string CoupleLongSex => throw new NotImplementedException();

        public string CoupleClitor => throw new NotImplementedException();

        public string CoupleVagina => throw new NotImplementedException();

        public string CoupleAnus => throw new NotImplementedException();

        public string CoupleOtherZone => throw new NotImplementedException();

        public string LocationPublic => throw new NotImplementedException();

        public string RoleForDistant => throw new NotImplementedException();

        public string SensationRelief => throw new NotImplementedException();
    }
}
