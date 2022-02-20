using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class QuestionRUS : ILanguageQuestion
    {
        public string Menu { get; } = "Спокойно, не торопясь кликай по кнопкам и выбирай что тебе больше подходит, нравится. Секс - игрушки в большинстве противоречиво универсальны и уникальны. Стоит учесть ряд важных моментов (характеристики) и собственных ощущений (енто уже всё оставшееся). Ну а вообще экспериментируйте, но главное чтобы было комфортно";
        public string ChooseMore { get; } = "Можешь выбрать ещё, как закончишь - жми 'готово'";
        public string Allergy { get; } = "Если имеешь аллергию или раздражение, а может ты не приемлешь данный материал, то кликай на него";
        public string Lubricant { get; } = $"Выбери каким лубрикантом пользуешься/собираешься. Лубрикант влияет на материал игрушки, поэтому для более долгой работы и безопасности собственной нужно подобрать одно под другое.Плюшка* лубрикант добавит большей чувственности, а ещё эффект кунилингуса от вакуумников с ним более выраженный. А здесь можешь прочесть нужную информацию по лубрикантам:{String.Format("https://t.me/who_if_not_hand/5")}";
        public string StateNeedOfLubricant { get; } = "Всё же предлагаю прочесть статью о том когда необходимы лубриканты, если тебе это не нужно, то оставь характеристку без выбора";
        public string StateWichOfLubricant { get; } = "Тут ты можешь прочесть статью о том какой лубрикант выбрать - если не важно, то оставь характеристику не заполненной";
        public string Role { get; } = "Секс - девайсы по мимо руки иногда западают в сердечко. Здесь можешь конкретизировать какая роль в твоей жизни будет у игрушки:";
        public string Agregate { get; } = "Просто выбери по типу. Жидкий - это различные гели, лубриканты и подобное. Твердый - это 'привычный' девайс, он не растечется и имеет определенную форму?";
        public string Where { get; } = "В целом на нашем теле есть куча зон для стимуляции, здесь выбери типичные, для зон за пределами вульвы вибратор также подойдет. По статистике 80% девушек необходима клиторальная стимуляция для получения оргазма, так что если до этого не получала 'то самое', то можно попробовать как раз?";
        public string Fetish { get; } = "Включаем воображение, вспоминаем свои желания и кликаем *всё только по согласию, так что кликай, если хочешь";
        public string Location { get; } = "Выбери какие локации хочешь для этой забавы?";
        public string Controle { get; } = "Натягиваем шапочку из фольги и выбираем управление";
        public string Reusability { get; } = "Иногда ты понимаешь что нашла ту самую, а порой охота лишь one-night stand...";
        public string StealthView { get; } = "Можно выбрать игрушку после которой уйдут все ненужные..мм..вопросы";
        public string SizeOfHand { get; } = "Руку всё же не получится положить в ящик, но выпал шанс договриться с ней о размере. *Размер ручки игрушки";
        public string Sensation { get; } = "Включаем вульву и кликаем, можно попробовать спиритическую доску..как излюбится нуу или чем. В общем, что хочешь чувствовать?";
        public string Couple { get; } = "Раз смотрим игрушку для пары, то учти, что в целом все игрушки подойдут, поэтому здесь выбери какую конкретно функцию охота опробывать";
        public string Stimulation { get; } = "Снова нам придется подключить вульву (или что-то другое всё же?). Какая вибрация ей интересна? ";
        public string TechniqueOfFap { get; } = "Пикантные вопросы, хотя до этого вроде были такие же.. Но всё же, для какой мастурбации хочешь, чтобы подходила игрушка? ";
        public string Language { get; } = "Порой язык многое решает. Какой подключим?";
        //For Menu
        public string Characteristic { get; } = "Определимся с общими характеристиками игрушки. Здесь стоит хорошо подумать и прочувствовать что нужно телу. ";
        public string Ecology { get; } = "Секс тоже можно сделать более экологичным. Только не надо из-за этого отказываться от салфеток и презервативов. Во - первых, средства безопасности это некий 'необходимый' отход, как и рахличные медицинские. Во -вторых И в главных, это средство вашей безопасности (примерное каждый 25 заражен ИППП),а вообще без заботы о себе тяжело заниматься экологизацией секса или других аспектов жизни. Советую выбирать игрушки действительно с умом и по необходимости. Покупайте что ВЫ дествительно желаете. А ещё лучше выбрать многоразовую игрушку с аккумулятором, так она прослужит дольше и не придется часто выкидывать батарейки и покупать новые";
        public string Stels { get; } = "Сейчас на рынке секс - девайсов легко можно выбрать игрушку, которая не будет похожа на эрегированный член или на какой-либо другой член. Так что кликай, важно ли тебе чтобы внешний вид игрушки был непримечательным";
        public string Feeling { get; } = "Всё, давай по ощущениям пройдемся. Теперь приятная часть, релаксируем и тыкаем по кнопкам";
        public string Wishes { get; } = "Таак, игрушка будет прилагаться к тебе и желательно, чтобы всё же она была с пользой. Так что выбирай себя её функции";
        public string States { get; } = "Здесь можно прочесть интересные статьи";
    }

    class ButtonRUS : ILanguageButton
    {
        public string Apply { get; } = "Применить";
        public string Ready { get; } = "Готово";
        public string Result { get; } = "Результат";
        public string Return { get; } = "Назад";
        public string NotClue { get; } = "Без понятия";
        public string Next { get; } = "Далее";
        public string NoMatters { get; } = "Не имеет значение";
        public string AllergySilikon { get; } = "Силикон";
        public string AllergyLatex { get; } = "Латекс";
        public string AllergyBioSkin { get; } = "BioSkin";
        public string AllergyTPR { get; } = "TPR";
        public string AllergyABS_plastic { get; } = "ABS_пластик";
        public string LibricantWater { get; } = "Водный";
        public string LibricantSilicon { get; } = "Силиконовый";
        public string LibricantOily { get; } = "Масляной";
        public string LibricantWaterSilicon { get; } = "Водно-силиконовый";
        public string LibricantWaterOily { get; } = "Водно-масляной";
        public string LibricantNoMatters { get; } = "Не считаю лубрикант важным";
        public string RoleForSelf { get; } = "Она будет только для меня";
        public string RoleForCouples { get; } = "Можно попробовать её в паре";
        public string RoleForSecret { get; } = "Она это мой новый секрет";
        public string RoleForDistant { get; } = "Для секса на расстоянии";
        public string AgregateLiquid { get; } = "Жидкий вибратор";
        public string AgregateHard { get; } = "Твердая игрушка";
        public string LocationBed { get; } = "Кровать";
        public string LocationBath { get; } = "Ванна";
        public string LocationShower { get; } = "В душе";
        public string LocationSea { get; } = "Море, или речечка..";
        public string LocationPool { get; } = "Бассейн";
        public string LocationPublic { get; } = "Публичное что-то";
        public string FetishPublicPlace { get; } = "Можно попробовать в публичном месте, чтобы никто не заметил";
        public string FetishDoublePenetration { get; } = "Секс втроем, вчетвером...";
        public string FetishGameWithPartner { get; } = "Пусть партнер управляет игрушкой";
        public string FetishDistantPartner { get; } = "Секс на расстоянии хочу";
        public string FetishPetGame { get; } = "Хочу почувствовать себя питомцем";
        public string FetishAnalSex { get; } = "Анальный?";
        public string FetishFeelPlenum { get; } = "Нравится ощущении заполненности";
        public string FetishSecretGame { get; } = "Пусть никто не знает что у меня внутри";
        public string FetishRealistic { get; } = "Реалистичность пениса";
        public string FetishBukaki { get; } = "Букаки";
        public string FetishIntel { get; } = "Пусть вибратор управляет";
        public string FetishCuni { get; } = "Кунилингус, да, такое тоже можно";
        public string FetishFillPlace { get; } = "Хочу прочувствовать местность, наслаждаться музыкой";
        public string StimulationVacuum { get; } = "Пульсирующие, похлопывающие стимуляции";
        public string StimulationWave { get; } = "Волнообразные движения в зоне клитора, губ";
        public string StimulationRotation { get; } = "Окатывание воздухом, динамичные круговые движения";
        public string ControleManual { get; } = "Только своими ручками";
        public string ControleButton { get; } = "Кнопки на игрушке";
        public string ControleApp { get; } = "Хочу через приложение";
        public string ControleConsole { get; } = "Хочу игрушку на пульте управления";
        public string CoupleStopPenis { get; } = "Чтобы отрегулировать размер пениса";
        public string CoupleLongSex { get; } = "Хочу продлить секс";
        public string CoupleClitor { get; } = "Нужна дополнительная стимуляции клитора";
        public string CoupleVagina { get; } = "Стимуляции вагины";
        public string CoupleAnus { get; } = "Анальная пенетрация";
        public string CoupleOtherZone { get; } = "Стимуляции чувствительных зон тела";
        public string ReusabilityLot { get; } = "Многоразовая";
        public string ReusabilityOne { get; } = "Одноразовая";
        public string StealthViewNoMatters { get; } = "Для меня это не важно";
        public string StealthViewMatters { get; } = "Сливаемся с местностью..";
        public string S { get; } = "Меньше ладони";
        public string M { get; } = "Входит в ладонь и помещается хорошо";
        public string L { get; } = "Не помещается в ладонь";
        public string SensationSoft { get; } = "Мягкость поверхности";
        public string SensationHard { get; } = "Твердая! Не сжать";
        public string SensationCold { get; } = "Прохладность, холод небольшой";
        public string SensationMyTemperature { get; } = "Пусть будет не ощутима для тела";
        public string SensationSmoothness { get; } = "Гладкая, скользкая";
        public string SensationVelvety { get; } = "Бархатистость, вельвет, нежность";
        public string SensationRealistic { get; } = "Реальность..вены, естественное набухание";
        public string SensationRelief { get; } = "Рельефность, закрученность";//
        public string WhereClitor { get; } = "Стимуляция клитора";
        public string WhereVagina { get; } = "Интересна вагинальная стимуляция";
        public string WhereAnus { get; } = "Зона: анус";
        public string WhereClitorVagina { get; } = "Клиторально-вагинальная";
        public string WhereOtherPoint { get; } = "Другие чувствительные зоны выбираю";
        public string TechniqueOfFapMost { get; } = "Мост";
        public string TechniqueOfFapRabbimg { get; } = "Раббинг";
        public string TechniqueOfFapClitoris { get; } = "Клиторальная";
        public string TechniqueOfFapAnus { get; } = "Стимуляция ануса";
        public string TechniqueOfFapVagPenet { get; } = "Вагинальные пенетрации";
        public string TechniqueOfFapTemp { get; } = "Скачки температур";
        public string TechniqueOfFapHlopClitor { get; } = "Похлопывания";
        public string TechniqueOfFapRoundVulva { get; } = "Стимуляции половых губ";
        public string ChoseOfRecomennd { get; } = "Используй кнопки";
        public string LanguageRUS { get; } = "RUS";
        public string LanguageENG { get; } = "ENG";
        //For Question (Menu)
        public string Agregate { get; } = "Вид игрушки";
        public string Allergy { get; } = "Аллергии";
        public string Couple { get; } = "Парная игрушка";
        public string Fetish { get; } = "Фантазии";
        public string Location { get; } = "Локации для забавы";
        public string Lubricant { get; } = "Лубриканты";
        public string Reusability { get; } = "Многоразовость";
        public string Role { get; } = "Роль девайса";
        public string Sensation { get; } = "Прикосновения к телу";
        public string SizeOfHand { get; } = "Размеры";
        public string StateNeedOfLubricant { get; } = "Зачем нужен лубрикант?";
        public string StateWichOfLubricant { get; } = "Какой выбрать лубрикант?";
        public string StealthView { get; } = "Внешний вид";
        public string Stimulation { get; } = "Тип стимуляции";
        public string TechniqueOfFap { get; } = "Тип мастурбации";
        public string Where { get; } = "Зоны выгула";

        //For menu
        public string Characteristic { get; } = "Общие характеристики";
        public string Ecology { get; } = "Экологичность";
        public string Stels { get; } = "Маскировка";
        public string Feeling { get; } = "Телесные наслаждения";
        public string Wishes { get; } = "Пожелания от вагины";
        public string States { get; } = "Статьи";
    }
}