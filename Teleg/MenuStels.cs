using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuStels : Query
    {
        public MenuStels(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Stels;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StealthView] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.StealthView] },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
