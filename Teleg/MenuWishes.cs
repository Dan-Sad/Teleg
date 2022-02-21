using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuWishes : Query
    {
        public MenuWishes(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Role] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Role]},
                [telegram.Button.Location] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Location] },
                [telegram.Button.Fetish] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Fetish] },
                [telegram.Button.TechniqueOfFap] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.TechniqueOfFap] },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
