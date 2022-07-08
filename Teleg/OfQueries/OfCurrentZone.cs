using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfCurrentZone : Query
    {
        ComandChoose Clitor = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Vagina = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose Anal = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анал%'" };
        ComandChoose Combination = new ComandChoose() { sqlRequest = "Process LIKE '%смешанный%'" };
        public OfCurrentZone(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.CurrentZone;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Clitor] = Clitor,
                [telegram.Button.Vagina] = Vagina,
                [telegram.Button.Anal] = Anal,
                [telegram.Button.Combination] = Combination,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuZona },
            };

            CreateButtonResult();

            //GenButtons();
        }
    }
}