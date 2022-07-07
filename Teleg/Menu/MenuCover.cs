using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuCover : Query
    {
        ComandChoose Water = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Clean = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose Silicon = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
        ComandChoose Oil = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')" };

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
