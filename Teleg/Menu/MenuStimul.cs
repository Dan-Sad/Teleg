using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStimul : Query
    {

        ComandChoose Soft = new ComandChoose() {  sqlRequest = "[Form of stimulation] LIKE '%мягкая%'" };
        ComandChoose Fast = new ComandChoose() {  sqlRequest = "[Form of stimulation] LIKE '%быстрая%'"  };
        ComandChoose Slow = new ComandChoose() {  sqlRequest = "[Form of stimulation] LIKE '%медленная%'"  };
        ComandChoose Power = new ComandChoose() {  sqlRequest = "[Form of stimulation] LIKE '%мощная%'"  };

        public MenuStimul(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Stimul;
            sqlSeparator = " OR ";

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