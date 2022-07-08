using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuCover : Query
    {
        ComandChoose Water = new ComandChoose() { sqlRequest = "Waterproof LIKE '%да%'" };
        ComandChoose Clean = new ComandChoose() { sqlRequest = "(Material LIKE '%Cиликон%' OR Material LIKE '%Cтекло%' OR Material LIKE '%Нержавейка%' OR Material LIKE '%АБС%'AND Material LIKE '%Керамика%' OR Material LIKE '%Лакдерево%')"};
        ComandChoose Silicon = new ComandChoose() { sqlRequest = "(Material NOT LIKE '%Cиликон%' OR Material NOT LIKE '%Киберкожа%' OR Material NOT LIKE '%Дерево%' OR Material NOT LIKE '%Лакдерево%'OR Material NOT LIKE '%ТПЭ%')" };
        ComandChoose Oil = new ComandChoose() { sqlRequest = "(Material NOT LIKE '%Cиликон%' OR Material NOT LIKE '%Акрил%' OR Material NOT LIKE '%Дерево%' OR Material NOT LIKE '%Cиликон%' OR Material NOT LIKE '%Лакдерево%' OR Material NOT LIKE '%Латекс%' OR Material NOT LIKE '%Киберкожа%' OR Material NOT LIKE '%ПП%' OR Material NOT LIKE '%ТПЭ%')" };

        public MenuCover(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Feeling;

            buttons = new Dictionary<string, ComandChoose>()
            {
                
                [telegram.Button.Water] = Water,
                [telegram.Button.Clean] = Clean,
                [telegram.Button.Silicon] = Silicon,
                [telegram.Button.Oil] = Oil,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu},
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}
