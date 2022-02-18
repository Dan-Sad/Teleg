using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfSize : Query
    {
        public OfSize(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Allergy;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.S] = () => _telegram.sqlMes.Add("([Size of hand] < 7 )"),
                [telegram.Button.M] = () => _telegram.sqlMes.Add("([Size of hand] >= 7 AND [Size of hand] <= 12)"),
                [telegram.Button.L] = () => _telegram.sqlMes.Add("([Size of hand] >= 13)"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
