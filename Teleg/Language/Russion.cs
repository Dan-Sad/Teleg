using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class QuestionRUS : ILanguageQuestion
    {
        public string Menu { get; } = "Спокойно переходи по кнопкам меню и выбирай что больше желаешь. Секс-игрушки в большинстве противоречиво универсальны и уникальны. Стоит учесть ряд важных моментов (как характеристики) и собственных ощущений (пожеланий, чувств). Не бойся экспериментировать, но в комфорте. Свою чувственность можно повышать - а с помощью игрушек это делать приятнее, интереснее и легче ";
        public string ChooseMore { get; } = "Можешь выбрать ещё, как закончишь - жми 'готово'";
        public string Allergy { get; } = "Если имеешь аллергию или раздражение, а может ты не приемлешь какой-то материал, то кликай на него";
        public string Lubricant { get; } = $"Выбери каким лубрикантом пользуешься или собираешься. Лубрикант влияет на материал игрушки, поэтому для более долгой работы и собственной безопасности стоит подобрать одно под другое.Плюшка* лубрикант добавит большей чувствительности, а ещё эффект кунилингуса от вакуумников с ним более выраженный. А здесь можешь прочесть нужную информацию по лубрикантам: https://t.me/who_if_not_hand/5";
        public string StateNeedOfLubricant { get; } = "Всё же предлагаю прочесть статью о том когда необходимы лубриканты, если тебе это не нужно, то оставь характеристку без выбора";
        public string StateWichOfLubricant { get; } = "Тут ты можешь прочесть статью о том какой лубрикант выбрать - если не важно, то оставь характеристику не заполненной";
        public string Role { get; } = "Секс-девайсы может остаться не только в руке, но и в сердечке. Здесь можешь конкретизировать какая роль в твоей жизни будет у игрушки:";
        public string Agregate { get; } = "Выбери тип. Жидкий - это различные гели, лубриканты и подобное. У них часто есть эффект согревания, охлаждения, шипучки, возбуждения - за счет прилива крови. Твердый - это 'привычный' девайс, он не растечется и имеет определенную форму, в него можно поставить моторчики, мембраны и тогда будет ощутимая телу вибрация?";
        public string Where { get; } = "Наше тело умещает кучу зон для стимуляции, любой стимулятор можно использовать для ласок ног, пяток, сосков, ушек. Но, к сожалению не все вибраторы подходят для анальной, например стимуляции. Поэтому выбери здесь зону. По статистике 80% девушек необходима клиторальная стимуляция для получения оргазма, так что если до этого не получала 'то самое', то можно попробовать как раз?";
        public string Fetish { get; } = "Дай полный доступ своему воображению, вспомни, прочувствуй свои желания и кликай на то, что откликается";
        public string Location { get; } = "Нет одного места для твоих забав: выбери где бы желалось особенно или может место где хочешь развить чувственность";
        public string Controle { get; } = "Натягиваем шапочку из фольги и выбираем управление";
        public string Reusability { get; } = "Иногда ты понимаешь что нашла ту самую, а порой охота лишь one-night stand...";
        public string StealthView { get; } = "Можно выбрать игрушку после которой уйдут все ненужные..вопросы. Нужно ли тебе скрывать внешний вид игрушки?";
        public string SizeOfHand { get; } = "Руку всё же не получится положить в ящик, но выпал шанс договориться с ней о размере. *речь о размер ручки у игрушки, а не о самом стволе";
        public string Sensation { get; } = "Выбирает вульва, или можно попробовать спиритическую доску.. в общем как излюбится или чем. Что хочешь чувствовать, ощущать, чем наслаждаешься?";
        public string Couple { get; } = "Раз смотрим игрушку для пары, то учти, что в целом большинство игрушек так или иначе подойдут, поэтому здесь выбери какую конкретно функцию охота опробывать";
        public string Stimulation { get; } = "Снова нам придется подключить вульву (или что-то другое всё же?). Какая вибрация ей интересна? ";
        public string TechniqueOfFap { get; } = "Пикантные вопросы, хотя до этого вроде были такие же.. Для какой мастурбации хочешь, чтобы подходила игрушка? ";
        public string Language { get; } = "Порой язык многое решает..";
        //For Menu
        public string Characteristic { get; } = "Определимся с общими характеристиками игрушки. Здесь стоит хорошо подумать и прочувствовать что нужно телу. ";
        public string Ecology { get; } = "Секс тоже можно сделать более экологичным. Только не стоит из-за этого отказываться от салфеток и презервативов. Во-первых, средства безопасности это некий 'необходимый' отход, как и различные медицинские. Во-вторых И в главных, это средство вашей безопасности (примерное каждый 25 заражен ИППП),а вообще без заботы о себе тяжело заниматься экологизацией секса или других аспектов жизни. Советую выбирать игрушки действительно с умом и по необходимости. Покупайте что ВЫ дествительно желаете. А ещё лучше выбрать многоразовую игрушку с аккумулятором, так она прослужит дольше и не придется часто выкидывать батарейки и покупать новые";
        public string Stels { get; } = "Сейчас на рынке секс-девайсов легко можно выбрать игрушку, которая не будет похожа на эрегированный член или на какой-либо другой член. Так что кликай, важно ли тебе чтобы твой девайс был незамеченым посторонним глазом?";
        public string Feeling { get; } = "Самое приятное, пройдем по ощущениям. Тут можешь выбрать и зону прикосновений, и то какими ты хочешь чтобы были эти прикосновения. Почувствуй как хочешь себя касаться";
        public string Wishes { get; } = "Таак, игрушка будет прилагаться к тебе и желательно, чтобы всё же она была с пользой. Так что выбирай себе её прямые функции, зачем и что она сделает для тебя";
        public string States { get; } = "Здесь можешь прочесть затейные статьи";
    }

    class ButtonRUS : ILanguageButton
    {
        public string Apply { get; } = "Применить";
        public string Ready { get; } = "Готово";
        public string Result { get; } = "Результат";
        public string Return { get; } = "Назад";
        public string State { get; } = "Статья";
        public string NotClue { get; } = "Без понятия";
        public string Next { get; } = "Далее";
        public string NoMatters { get; } = "Не имеет значение";
        public string AllergySilikon { get; } = "Силикон";
        public string AllergyLatex { get; } = "Латекс";
        public string AllergyBioSkin { get; } = "BioSkin";
        public string AllergyTPR { get; } = "TPR";
        public string AllergyABS_plastic { get; } = "ABS_пластик";
        public string LubricantWater { get; } = "Водный";
        public string LubricantSilicon { get; } = "Силиконовый";
        public string LubricantOily { get; } = "Масляной";
        public string LubricantWaterSilicon { get; } = "Водно-силиконовый";
        public string LubricantWaterOily { get; } = "Водно-масляной";
        public string LubricantNoMatters { get; } = "Не считаю лубрикант нужным";
        public string RoleForSelf { get; } = "Будет для соло игр";
        public string RoleForCouples { get; } = "Можно в паре";
        public string RoleForSecret { get; } = "Секрет внутри меня";
        public string RoleForDistant { get; } = "Для секса на расстоянии";
        public string AgregateLiquid { get; } = "Жидкий вибратор";
        public string AgregateHard { get; } = "Твердая игрушка";
        public string LocationBed { get; } = "Кровать";
        public string LocationBath { get; } = "Ванна";
        public string LocationShower { get; } = "В душе";
        public string LocationSea { get; } = "Море, речечка..";
        public string LocationPool { get; } = "Бассейн";
        public string LocationPublic { get; } = "Публичное что-то";
        public string FetishPublicPlace { get; } = "Тайно и в публичном месте";
        public string FetishDoublePenetration { get; } = "Секс втроем, вчетвером...";
        public string FetishGameWithPartner { get; } = "Пусть партнер управляет игрушкой";
        public string FetishDistantPartner { get; } = "Секс на расстоянии хочу";
        public string FetishPetGame { get; } = "Почувствовать себя питомцем";
        public string FetishAnalSex { get; } = "Анальный секс";
        public string FetishFeelPlenum { get; } = "Нравится ощущении заполненности";
        public string FetishSecretGame { get; } = "Никто не знает что внутри меня";
        public string FetishRealistic { get; } = "Реалистичные пенисы";
        public string FetishBukaki { get; } = "Букаки";
        public string FetishIntel { get; } = "Пусть вибратор задаст процесс";
        public string FetishCuni { get; } = "Пожалуй кунилингус";
        public string FetishFillPlace { get; } = "Люблю под музыку";
        public string StimulationVacuum { get; } = "Пульсирующая, похлопывающая";
        public string StimulationWave { get; } = "Волнообразная с накатыванием";
        public string StimulationRotation { get; } = "Ротационная";
        public string ControleManual { get; } = "Только своими ручками";
        public string ControleButton { get; } = "Кнопки на игрушке";
        public string ControleApp { get; } = "Хочу через приложение";
        public string ControleConsole { get; } = "Игрушку на пульте управления";
        public string CoupleStopPenis { get; } = "Отрегулировать размер пениса";
        public string CoupleLongSex { get; } = "Хочу продлить секс";
        public string CoupleClitor { get; } = "Дополнительная стимуляция клитора";
        public string CoupleVagina { get; } = "Стимуляции вагины";
        public string CoupleAnus { get; } = "Анальная пенетрация";
        public string CoupleOtherZone { get; } = "Стимуляции любых зон тела";
        public string ReusabilityLot { get; } = "Многоразовая";
        public string ReusabilityOne { get; } = "Одноразовая";
        public string StealthViewNoMatters { get; } = "Для меня это не важно";
        public string StealthViewMatters { get; } = "Пусть сольётся с местностью";
        public string S { get; } = "Меньше ладони";
        public string M { get; } = "Входит в ладонь";
        public string L { get; } = "Не помещается в ладонь";
        public string SensationSoft { get; } = "Мягкость поверхности";
        public string SensationHard { get; } = "Твердая (металл, дерево)";
        public string SensationCold { get; } = "Прохладность, холод";
        public string SensationMyTemperature { get; } = "Не ощутима телу";
        public string SensationSmoothness { get; } = "Гладкая, скользкая";
        public string SensationVelvety { get; } = "Бархатистость, вельвет, нежность";
        public string SensationRealistic { get; } = "Вены, естественное набухание";
        public string SensationRelief { get; } = "Рельефность, закрученность";
        public string WhereClitor { get; } = "Стимуляция клитора";
        public string WhereVagina { get; } = "Вагинальная стимуляция";
        public string WhereAnus { get; } = "Зона ануса";
        public string WhereClitorVagina { get; } = "Клиторально-вагинальная";
        public string WhereOtherPoint { get; } = "Другие чувствительные зоны";
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
        public string Agregate { get; } = "Тип игрушки";
        public string Allergy { get; } = "Аллергии";
        public string Couple { get; } = "Парная игрушка";
        public string Fetish { get; } = "Желания";
        public string Location { get; } = "Локации для забавы";
        public string Lubricant { get; } = "Лубриканты";
        public string Reusability { get; } = "Многоразовость";
        public string Role { get; } = "Роль девайса";
        public string Sensation { get; } = "Ощущения для тела";
        public string SizeOfHand { get; } = "Размеры";
        public string StateNeedOfLubricant { get; } = "Зачем нужен лубрикант?";
        public string StateWichOfLubricant { get; } = "Какой выбрать лубрикант?";
        public string StealthView { get; } = "Внешний вид";
        public string Stimulation { get; } = "Тип стимуляции";
        public string TechniqueOfFap { get; } = "Тип мастурбации";
        public string Where { get; } = "Зоны выгула на теле";

        //For menu
        public string Characteristic { get; } = "Общие характеристики";
        public string Ecology { get; } = "Экологичность";
        public string Stels { get; } = "Маскировка";
        public string Feeling { get; } = "Хотения прикосновений";
        public string Wishes { get; } = "Пристрастия тела";
        public string States { get; } = "Статьи";
    }
}