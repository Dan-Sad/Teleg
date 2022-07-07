using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuEcology : Query
    {
        public MenuEcology(TelegConnect telegram) : base(telegram)
        {

            Question = telegram.Question.Ecology;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Reusability] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Reusability] },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu},

            };
            CreateButtonResult();

            GenButtons();
        }
    }
}
