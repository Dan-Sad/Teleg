using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    class MenuLimit : Query
    {
        ComandChoose Distant = new ComandChoose() { sqlRequest = "(signs LIKE '%пульт%' OR signs LIKE '%приложение%')"  };
        ComandChoose WithoutHand = new ComandChoose() { sqlRequest = "Control LIKE '%да%'" };
        ComandChoose Ergonomic = new ComandChoose() { sqlRequest = "Ergonomic LIKE '%да%'"};
        ComandChoose SmallDiametr = new ComandChoose() { sqlRequest = "(Langht LIKE '%да%' OR Langht LIKE '%маленький%')"};
        
        
        public MenuLimit(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Limit;

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