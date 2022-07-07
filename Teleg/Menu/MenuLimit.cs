using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    class MenuLimit : Query
    {
        ComandChoose Distant = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose WithoutHand = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Ergonomic = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose SmallDiametr = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Bandage = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        
        public MenuLimit(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Distant] = Distant,
                [telegram.Button.WithoutHand] = WithoutHand,
                [telegram.Button.Ergonomic] = Ergonomic,
                [telegram.Button.SmallDiametr] = SmallDiametr,
                [telegram.Button.Bandage] = Bandage,

                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}