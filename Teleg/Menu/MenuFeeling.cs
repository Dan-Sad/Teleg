using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuFeeling : Query
    {
        public MenuFeeling(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Feeling;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Where] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Where] },
                [telegram.Button.Stimulation] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Stimulation] },
                [telegram.Button.Sensation] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Sensation] },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu},
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}
