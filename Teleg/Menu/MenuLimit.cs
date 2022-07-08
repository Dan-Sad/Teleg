using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    class MenuLimit : Query
    {
        ComandChoose Distant = new MenuLimit() { sqlRequest = "(signs LIKE '%пульт%' OR signs LIKE '%приложение%')"  };
        ComandChoose WithoutHand = new MenuLimit() { sqlRequest = "Control LIKE '%да%'" };
        ComandChoose Ergonomic = new MenuLimit() { sqlRequest = "Ergonomic LIKE '%да%'"};
        ComandChoose SmallDiametr = new MenuLimit() { sqlRequest = "(Langht LIKE '%да%' OR Langht LIKE '%маленький%')"};
        
        
        public MenuLimit(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Distant] = Distant,
                [telegram.Button.WithoutHand] = WithoutHand,
                [telegram.Button.Ergonomic] = Ergonomic,
                [telegram.Button.SmallDiametr] = SmallDiametr,
                

                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}