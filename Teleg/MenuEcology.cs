using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuEcology
    {
        int i = 0;
        public MenuEcology(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Ecology;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Reusability] = () => _telegram.sqlMes.Add("()"),//

            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
