using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStyle : Query
    {
        ComandChoose Natural = new ComandChoose() { sqlRequest = "(Material LIKE '%Дерево%' OR Material LIKE '%Cтекло%' OR Material LIKE '%Нержавейка%' OR Material LIKE '%Сталь%'AND Material LIKE '%Керамика%' OR Material LIKE '%Лакдерево%')" };
        ComandChoose Steal = new ComandChoose() { sqlRequest = "Style LIKE '%скрытый%'" };

        public MenuStyle(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Style;

            buttons = new Dictionary<string, ComandChoose>()
            {
                
                [telegram.Button.Natural] = Natural,
                [telegram.Button.Steal] = Steal,
                [telegram.Button.Color] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Color] },
                [telegram.Button.Likeon] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Likeon] },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}
