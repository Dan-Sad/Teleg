using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuSates
    {

        public MenuSates(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.States;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StateNeedOfLubricant] = () => _telegram.sqlMes.Add(""),
                [telegram.Button.StateWichOfLubricant] = () => _telegram.sqlMes.Add(""),

            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
