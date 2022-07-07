using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStyle : Query
    {
        ComandChoose Natural = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Steal = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };

        public MenuStyle(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Stels;

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
