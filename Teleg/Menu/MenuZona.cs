using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuZona : Query
    {

        ComandChoose Outside = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Inside = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose Mix = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };

        public MenuZona(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Characteristic;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Outside] = Outside,
                [telegram.Button.Inside] = Inside,
                [telegram.Button.Mix] = Mix,
                [telegram.Button.CurrentZone] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.CurrentZone] },

                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },

            };

            CreateButtonResult();

            GenButtons();
        }
    }
}
