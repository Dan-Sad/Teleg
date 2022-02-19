using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuStels
    {

        public MenuStels(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Stels;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StealthView] = () => _telegram.sqlMes.Add(""),
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
