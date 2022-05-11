using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuCharacteristic : Query
    {
        public MenuCharacteristic(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Characteristic;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Allergy] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Allergy] },
                [telegram.Button.Lubricant] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Lubricant] },
                [telegram.Button.Agregate] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Agregate] },
                [telegram.Button.SizeOfHand] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.SizeOfHand] },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },

            };

            CreateButtonResult();

            GenButtons();
        }
    }
}
