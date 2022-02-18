using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class QuestionRUS : ILanguageQuestion
    {
        public string ChooseMore { get; } = "Ты можешь выбрать больше или жми 'Далее'";
        public string Allergy { get; } = "Аллергия?";
        public string Lubricant { get; } = "Какой лубрикант изберете?";
        public string StateNeedOfLubricant { get; } = "Советую прочесть статью о необходимости лубриканта";
        public string StateWichOfLubricant { get; } = "Здесь можешь выбрать какой больше подойдет";
        public string Role { get; } = "Кем пожелаете быть вашей игрушке";
        public string Agregate { get; } = "Что же Вас прельщает?";
        public string Where { get; } = "Небезызвестно о 80% девушек жаждующих клиторальную стимуляцию для полного наслаждения. Что полюбилось Вам?";
        public string Fetish { get; } = "Свои хотения желаем претворить?";
        public string Location { get; } = "На каких просторах будет происходить забава?";
        public string Controle { get; } = "Натягиваем шапочку из фольги и выбираем управление";
        public string Reusability { get; } = "Иногда ты понимаешь что нашла ту самую...";
        public string StealthView { get; } = "Мы так и будем скрывать эту забаву ото всех?";
        public string SizeOfHand { get; } = "Руку всё же не получится положить в ящик, но выпал шанс договриться (речь не о размере страпона, а о месте за которое будет держаться рука)";
        public string Sensation { get; } = "Какие чувствования выбираем?// ощущения холод бархат";
        public string Stimulation { get; } = "Три два один ..думаем гениталиями (или чем излюбится)//тип вибрации";
        public string TechniqueOfFap { get; } = "Освежи тот самый день или создай новый. Какая мастурбация? ";
        public string Language { get; } = "Некоторые соприкосновения языками самые важные. Какой язык выберем?";
    }

    class ButtonRUS : ILanguageButton
    {
        public string Result { get; } = "Результат";
        public string Return { get; } = "Назад (перевыбор)";
        public string NotClue { get; } = "Без понятия";
        public string Next { get; } = "Далее";
        public string NoMatters { get; } = "Не имеет значение";
        public string AllergySilikon { get; } = "На силикон";
        public string AllergyLatex { get; } = "На латекс";
        public string AllergyBioSkin { get; } = "На BioSkin";
        public string AllergyTPR { get; } = "На TPR";
        public string AllergyABS_plastic { get; } = "На ABS_пластик";
        public string LibricantWater { get; } = "Водный";
        public string LibricantSilicon { get; } = "Силиконовый";
        public string LibricantOily { get; } = "Масляной";
        public string LibricantWaterSilicon { get; } = "Водно-силиконовый";
        public string LibricantWaterOily { get; } = "Водно-масляной";
        public string LibricantNoMatters { get; } = "Не считаю лубрикант важным";
        public string RoleForSelf { get; } = "Только моей!";
        public string RoleForCouples { get; } = "Можно попробовать и в паре";
        public string RoleForSecret { get; } = "У каждого должен быть секрет";
        public string RoleForDouble { get; } = "Предпочитаю секс на расстоянии";
        public string AgregateLiquid { get; } = "Жидкий вибратор";
        public string AgregateHard { get; } = "Твердой консистенции игрушка";
        public string LocationBed { get; } = "Кровать";
        public string LocationBath { get; } = "Ванна";
        public string LocationShower { get; } = "Душ";
        public string LocationSea { get; } = "Хочу на море, ну или хотя бы в речечке";
        public string LocationPool { get; } = "Окей, подойдет и бассейн";
        public string FetishPublicPlace { get; } = "Как насчет публичных мест";
        public string FetishDoublePenetration { get; } = "Может тройничек?";
        public string FetishGameWithPartner { get; } = "Стоит довериться партнеру";
        public string FetishDistantPartner { get; } = "Секс на расстоянии";
        public string FetishPetGame { get; } = "Представь меня собачкой";
        public string FetishAnalSex { get; } = "Классика жанра.. анальный";
        public string FetishFeelPlenum { get; } = "Чувство заполненности//анальные пробки";
        public string FetishSecretGame { get; } = "Никто не будет знать что ты таишь в себе";
        public string FetishRealistic { get; } = "Воспоминания о реальности в сексе";
        public string FetishBukaki { get; } = "Можно и на лицо";
        public string FetishBDSM { get; } = "Всё просто-BDSM ";
        public string FetishIntel { get; } = "Вибратор всё помнит - доверься";
        public string FetishCuni { get; } = "И даже кунилингус можно";
        public string FetishFillPlace { get; } = "Слейся с местностью//вибратор под музыку, окружающую среду";
        public string StimulationVacuum { get; } = "Воссоздаю события кунилингуса";
        public string StimulationWave { get; } = "Волнообразные, мягкие движения у клитора";
        public string StimulationVagina { get; } = "Заполненность вагины ";
        public string StimulationClitor { get; } = "Пульсация, похлопывания клитора";
        public string StimulationMechanical { get; } = "Без вибраций, я руками";
        public string StimulationRotation { get; } = "Окатывание воздухом, охлаждение клитора";
        public string StimulationAnus { get; } = "Чувство полноты, давление на анус";
        public string ControleManual { get; } = "Только своими ручками";
        public string ControleButton { get; } = "Кнопки на игрушке";
        public string ControleApp { get; } = "Хочу через приложение";
        public string ControleConsole { get; } = "Хочу игрушку на пульте управления";
        public string ReusabilityLot { get; } = "Пусть останется со мной надолго";
        public string ReusabilityOne { get; } = "Мне эту забаву на одну ночь";
        public string StealthViewNoMatters { get; } = "Мне это не важно";
        public string StealthViewMatters { get; } = "Сливаемся с местностью";
        public string S { get; } = "Меньше ладони";
        public string M { get; } = "Входит в ладонь и помещается хорошо";
        public string L { get; } = "Однозначно не помещается в ладонь";
        public string SensationSoft { get; } = "Мягкость при прикосновении";
        public string SensationHard { get; } = "Твердое! И втроем не сожмешь";
        public string SensationCold { get; } = "Холод, прохлада";
        public string SensationMyTemperature { get; } = "Не ощутима,ничего нет, есть только ощущения";
        public string SensationSmoothness { get; } = "Гладкий, скользкий, может глянец?";
        public string SensationVelvety { get; } = "Бархатистость, вельвет, нежнее нежного";
        public string SensationRealistic { get; } = "Реальность..рельефные вены, естественное набухание";
        public string WhereClitor { get; } = "Клитор";
        public string WhereVagina { get; } = "Вагина";
        public string WhereAnus { get; } = "Анус";
        public string WhereClitorVagina { get; } = "И клитор, и вагину";
        public string WhereOtherPoint { get; } = "Другие особо чувствительные зоны";
        public string TechniqueOfFapMost { get; } = "Мост";
        public string TechniqueOfFapRabbimg { get; } = "Раббинг (потереться обо что-то)";
        public string TechniqueOfFapClitoris { get; } = "Клиторальная";
        public string TechniqueOfFapAnus { get; } = "Стимуляция ануса";
        public string TechniqueOfFapVagPenet { get; } = "Вагинальные пенетрации";
        public string TechniqueOfFapTemp { get; } = "Скачки температур";
        public string TechniqueOfFapHlopClitor { get; } = "Похлопывания клитора";
        public string TechniqueOfFapRoundVulva { get; } = "Нежные круговые движения внутри вульвы";
        public string ChoseOfRecomennd { get; } = "Используй кнопки";
        public string LanguageRUS { get; } = "RUS";
        public string LanguageENG { get; } = "ENG";
    }
}