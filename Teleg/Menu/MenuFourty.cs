using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    class MenuFourty : Query
    {
        ComandChoose Vacuum = new ComandChoose() { sqlRequest = sqlRequest = "signs LIKE '%всасывание%'"  };
        ComandChoose Smoothness = new ComandChoose() { sqlRequest = "Relief LIKE '%нет%'" };
        ComandChoose SmallDiametr = new MenuLimit() { sqlRequest = "(Langht LIKE '%да%' OR Langht LIKE '%маленький%')" };
        ComandChoose Distant = new MenuLimit() { sqlRequest = "(signs LIKE '%пульт%' OR signs LIKE '%приложение%')"};
        ComandChoose WithoutHand = new MenuLimit() { sqlRequest = "Control LIKE '%да%'" };
        ComandChoose Ergonomic = new MenuLimit() { sqlRequest = "Ergonomic LIKE '%да%'" };
        ComandChoose Power = new ComandChoose() { sqlRequest = "[Form of stimulation] LIKE '%мощная%'" };
        ComandChoose Silicon = new ComandChoose() { sqlRequest = "(Material NOT LIKE '%Cиликон%' OR Material NOT LIKE '%Киберкожа%' OR Material NOT LIKE '%Дерево%' OR Material NOT LIKE '%Лакдерево%'OR Material NOT LIKE '%ТПЭ%')" };
        ComandChoose Oil = new ComandChoose() { sqlRequest = "(Material NOT LIKE '%Cиликон%' OR Material NOT LIKE '%Акрил%' OR Material NOT LIKE '%Дерево%' OR Material NOT LIKE '%Cиликон%' OR Material NOT LIKE '%Лакдерево%' OR Material NOT LIKE '%Латекс%' OR Material NOT LIKE '%Киберкожа%' OR Material NOT LIKE '%ПП%' OR Material NOT LIKE '%ТПЭ%')" };

        public MenuFourty(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Smoothness] = Smoothness,
                [telegram.Button.Distant] = Distant,
                [telegram.Button.Ergonomic] = Ergonomic,
                [telegram.Button.SmallDiametr] = SmallDiametr,
                [telegram.Button.Bandage] = Bandage,
                [telegram.Button.WithoutHand] = WithoutHand,
                [telegram.Button.Power] = Power,
                [telegram.Button.Vacuum] = Vacuum,
                [telegram.Button.Silicon] = Silicon,
                [telegram.Button.Oil] = Oil,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}