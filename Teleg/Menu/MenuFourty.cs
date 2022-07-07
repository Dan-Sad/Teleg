using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    class MenuFourty : Query
    {
        ComandChoose Vacuum = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Smoothness = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose SmallDiametr = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Distant = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Ergonomic = new MenuLimit() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Power = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')" };
        ComandChoose Silicon = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
        ComandChoose Oil = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')" };

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