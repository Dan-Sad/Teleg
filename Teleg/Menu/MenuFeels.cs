using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
    internal class MenuFeels : Query
    {

        ComandChoose Wight = new ComandChoose() { sqlRequest = "signs LIKE '%широкий%'" };
        ComandChoose Depth = new ComandChoose() { sqlRequest = "signs LIKE '%глубокие%'"  };
        ComandChoose Suction = new ComandChoose() { sqlRequest = "signs LIKE '%всасывание%'"  };
        ComandChoose Tingling = new ComandChoose() { sqlRequest = "signs LIKE '%покалывающие%'" };
        ComandChoose Pushers = new ComandChoose() { sqlRequest = "signs LIKE '%толкающие%'"  };
        ComandChoose Pulsators = new ComandChoose() { sqlRequest = "signs LIKE '%пульсации%'"  };
        ComandChoose Smoothness = new ComandChoose() { sqlRequest = "Relief LIKE '%нет%'" };
        ComandChoose Texture = new ComandChoose() { sqlRequest = "Relief LIKE '%да%'" };
        ComandChoose Heating = new ComandChoose() { sqlRequest = "Heat LIKE '%да%'" };
        ComandChoose Massage = new ComandChoose() { sqlRequest = "signs LIKE '%массаж%'"  };
        ComandChoose Wave = new ComandChoose() { sqlRequest = "signs LIKE '%волновые%'"  };
        ComandChoose Vibration = new ComandChoose() { sqlRequest = "signs LIKE '%вибрации%'"  };
             public MenuFeels(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Feels;

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
                [telegram.Button.Wave] = Wave,
                [telegram.Button.Vibration] = Vibration,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}