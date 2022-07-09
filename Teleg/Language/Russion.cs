using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class QuestionRUS : ILanguageQuestion
    {
        public string CurrentZone { get; } = "Выбери какую/какие зоны хочешь стимулировать";
        public string Color { get; } = "Может хочешь собрать коллекцию розовых игрушек или хочешь чтобы девайс вписался в интерье?";
        public string Likeon { get; } = "Какой стиль ассоциируется с твоей игрушкой? Но помни, что это только внешний вид и на функции влияет только эстетически";
               
        //For menu
        public string Menu { get; } = "Идеальной секс-игрушки нет, а поэтому выберите те характеристики, что важны для вас. Можно разнообразить соло-секс, найти другие эрогенные зоны, добавить новое в парный секс, или же можете просто наслаждаться процессом.";
        public string Fourty { get; } = "У женщин среднего и старшего возраста могут быть измененные предпочтения по секс-девайсам. Так в этом возрасте у некоторых снижается приток крови к гениталиям и поэтому может лучше подойти более интенсивные вибраторы, некоторым нравятся вакуумные стимуляторы.Также увеличивается чувствительность и поэтому могут подойти более гладкие материалы, корпусаДанные критерии могут помочь вам выбрать подходящий девайс, а если вы хотите дополнить список критериев, то пишите мне, и я обязательно учту это.";
        public string Cover { get; } = "Так как вульва обладает высокой восприимчивостью к бактериям, поэтому стоит подойти к выбору материала серьезно. Так учтите, насколько вы готовы ухаживать за игрушкой, например, за высокопористыми игрушками нужен больший уход и покупка той-клинеров, так как в порах скапливаются вредные жители. Также от материала зависит то, какие лубриканты подойдут для секса. ";
        public string Ecology { get; } = "Покупая девайс, вы выбираете кого и что спонсировать. Этим указываете путь какие направления общество поддерживает, а какие нет. Поэтому я призываю относиться к покупке секс-игрушки осознанно: 1. Секс-игрушка, как и другие электронные устройства можно сдать в переработку. Также вы можете отнести игрушки в ряд некоторых секс-шопов и там даже дадут скидку на покупку новой.  2. Одна батарейка загрязняет 20 м2 и 400 л воды. При этом игрушки с аккумулятором можно зарядит и продолжить использовать, а вот за батарейкой нужно уже бежать в магазин.  3. Если у продукции написано веган, то действительно компания не тестирует свои игрушки на животных. Но, к сожалению, материалы при использовании человеком внутри себя по нормам FDA обязаны проходить проверку на животных, поэтому учитываете, что материал будет скорее всего не веган. 4. Под этичное производство попадают компании, которые не дискриминируют своих работников и испытуемых по половому, расовому, сексуальному, экономическому положению. Дающую достойную оплату труда. Также, заботящиеся над секс просвещением. ";
        public string Feels { get; } = "Что хотите чувствовать, что важно в ощущениях. Подумайте над каждым выбором";
        public string Limit { get; } = "Если вы имеете ограниченные возможности, то ряд критериев ниже может отсеять игрушки, что потенциально могут не подойти. Здесь не учтено всё, и поэтому, буду рада если вы сообщите мне что стоит добавить, так как данные критерии индивидуальны. Эта категория важна и мало представлена в исследованиях, спасибо, если сможете дополнить её ";
        public string Process { get; } = "Идеальных нет. И тут, кому-то охота валяться с подушками, кто-то хочет исследовать всё свое тело, а кто-то уже выбрал одну зону и надо только там стимулировать. ";
        public string States { get; } = "Можешь узнать больше по актуальным вопросам:";
        public string Stimul { get; } = "Вспомните насколько чувствительна ваша зона от этого выбирайте мягкая или сильная стимуляция. Вы хотите долгие процесс или быстрый. Но если вы не знаете, то предлагаю выбрать вариант с большим числом интенсивностей.";
        public string Style { get; } = "Хотите ли вы чтобы девайс вписался в ваш интерьер или может нужно его спрятать от ненужных глаз. Возможно вы выбираете в подарок и нужна красивая или необычная подача. ";
        public string Zona { get; } = "Несмотря на то, что около 70% женщин нуждаются в клиторальной стимуляции для оргазма, никто не запрещает вам наслаждаться другими зонами тела. Тем более, что некоторые девайся позволят найти новое, а некоторые, например, кролики, помогут в тренировки вагинальной чувствительности";

        //For system
        public string ChooseMore { get; } = "Можешь выбрать больше";
        public string Language { get; } = "Иногда без языка не обойтись";

        public string StateNeedOfLubricant { get; } = "Зачем";
        public string StateWichOfLubricant { get; } = "Какой";



    }

    class ButtonRUS : ILanguageButton
    {
        //For system
        public string Apply { get; } = "Применить";
        public string Ready { get; } = "Готово";
        public string Result { get; } = "Результат";
        public string Return { get; } = "Назад";
        public string State { get; } = "Статья";
        public string NotClue { get; } = "Без понятия";
        public string Next { get; } = "Далее";
        public string NoMatters { get; } = "Не имеет значение";
        public string ChoseOfRecomennd { get; } = "Используй кнопки";
        public string LanguageRUS { get; } = "RUS";
        public string LanguageENG { get; } = "ENG";
        public string CurrentZone { get; } = "Конкретная зона";
        public string Color { get; } = "Цвет";
        public string Likeon { get; } = "Стиль";
        public string StateNeedOfLubricant { get; } = "Зачем лубриканты";
        public string StateWichOfLubricant { get; } = "Выбрать лубрикант";


        //For Menu
        public string Fourty { get; } = "40+";
        public string Cover { get; } = "Корпус и материал";
        public string Ecology { get; } = "Этика и экология";
        public string Feels { get; } = "Ощущения";
        public string Limit { get; } = "Ограниченные возможности";
        public string Process { get; } = "Действия";
        public string States { get; } = "Статьи";
        public string Stimul { get; } = "Вид стимуляции";
        public string Style { get; } = "Эстетика";
        public string Zona { get; } = "Зоны стимуляции";

        //Cover
        public string Water { get; } = "Можно использовать в воде";
        public string Clean { get; } = "Легкая очистка";
        public string Silicon { get; } = "Можно с силиконовой смазкой";
        public string Oil { get; } = "Можно с масляной смазкой";
        
        //Ecology
        public string Battery { get; } = "Перезаряжаемый через аккумулятор";
        public string Vegan { get; } = "Веган";
        public string Factory { get; } = "Этичная компания";

        //Feels

        public string Wight { get; } = "Широкие";
        public string Depth { get; } = "Глубокие";
        public string Suction { get; } = "Всасывающие";
        public string Tingling { get; } = "Покалывающие";
        public string Pushers { get; } = "Толкающие";
        public string Pulsators { get; } = "Пульсирующие";
        public string Smoothness { get; } = "Гладкость";
        public string Texture { get; } = "Чувствовать текстуру";
        public string Heating { get; } = "Подогрев";
        public string Massage { get; } = "Массаж";
        public string Wave { get; }= "Волнообразные";
        public string Vibration { get; }= "Вибрации";

        //Fourty


        public string Distant { get; } = "Дистанционное управление: пульт или приложение";
        public string Ergonomic { get; } = "Удобная ручка";
        public string SmallDiametr { get; } = "Небольшой диаметр";
        public string Bandage { get; } = "Использование с бандажом";
        public string Power { get; } = "Мощная";
        public string Vacuum { get; } = "Вакуумная стимуляция";
         
        //Limit
        public string WithoutHand { get; } = "Не используя рук";

        //Process

        public string Search { get; } = "Эксперименты и поиск";
        public string Point { get; } = "Точечная";
        public string MixOrgasm { get; } = "Смешанные оргазмы";
        public string Pillow { get; } = "Валяться с подушками";
        public string NewTech { get; } = "Пробовать новые технологии";
        public string Boy { get; } = "С партнером";
        public string Girl { get; } = "С партнершей";
        public string Public { get; } = "Носить внутри себя";

        //Stimul
        public string Soft { get; } = "Мягкая";
        public string Fast { get; } = "Быстрая";
        public string Slow { get; } = "Медленная";


        //Style
        public string Natural { get; } = "Натуральные материалы: стекло, металл";
        public string Steal { get; } = "Замаскировано под другой предмет: губная помада";

        //Zona
        public string Outside { get; } = "Внутренняя";
        public string Inside { get; } = "Наружная";
        public string Mix { get; } = "Смешанная";

        //CurrentZone

        public string Clitor { get; } = "Клоторальная";
        public string Vagina { get; } = "Вагинальная";
        public string Anal { get; } = "Анальная";
        public string Combination { get; } = "Комбинированная";

        //Color
        public string White { get; } = "Белая";
        public string Black { get; } = "Черная";
        public string Red { get; } = "Красная";
        public string Green { get; } = "Зеленая";
        public string Blue { get; } = "Синяя";
        public string Yellow { get; } = "Желтая";
        public string Gray { get; } = "Серая";
        public string Pink { get; } = "Розовая";
        public string Violent { get; } = "Фиолетовая";
        public string Dark { get; } = "Темная гамма";
        public string Metal { get; } = "Металик";
        public string Light { get; } = "Светлая гамма";
        public string Gentle { get; } = "Нежные цвета";
        public string Bright { get; } = "Яркие цвета";

        //Likeon 

        public string Space { get; } = "Космос";
        public string Usually { get; } = "Обычный";
        public string Minimalism { get; } = "Минимализм";
        public string Animal { get; } = "Животный стиль";
        public string Child { get; } = "Под детские игрушки";
        public string Realistic { get; } = "Реалистичная игрушка";
        public string Stimpank { get; } = "Стимпанк";

    }
}