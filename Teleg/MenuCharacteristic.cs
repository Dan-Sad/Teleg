using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuCharacteristic
    {
        int i = 0;
        public MenuCharacteristic(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Characteristic;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Allergy] = () => _telegram.sqlMes.Add("()"),//
                [telegram.Button.Lubricant] = () => _telegram.sqlMes.Add("()"),//
                [telegram.Button.Agregate] = () => _telegram.sqlMes.Add("()"),//
                [telegram.Button.SizeOfHand] = () => _telegram.sqlMes.Add("()"),//

            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
