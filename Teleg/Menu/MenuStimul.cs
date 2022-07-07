using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStimul : Query
    {

        ComandChoose Soft = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Fast = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose Slow = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
        ComandChoose Power = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')" };

        public MenuStimul(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Soft] = Soft,
                [telegram.Button.Fast] = Fast,
                [telegram.Button.Slow] = Slow,
                [telegram.Button.Power] = Power,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu},
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}