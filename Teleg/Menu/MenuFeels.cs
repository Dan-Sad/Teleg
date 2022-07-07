using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    class MenuFeels : Query
    {

        ComandChoose Wight = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Depth = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose Suction = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
        ComandChoose Tingling = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')" };
        ComandChoose Pushers = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Pulsators = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Smoothness = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Texture = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Heating = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Massage = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
             public MenuFeels(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Wight] = Wight,
                [telegram.Button.Depth] = Depth,
                [telegram.Button.Suction] = Suction,
                [telegram.Button.Tingling] = Tingling,
                [telegram.Button.Pushers] = Pushers,
                [telegram.Button.Pulsators] = Pulsators,
                [telegram.Button.Smoothness] = Smoothness,
                [telegram.Button.Texture] = Texture,
                [telegram.Button.Heating] = Heating,
                [telegram.Button.Massage] = Massage,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}