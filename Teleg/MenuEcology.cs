using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuEcology : Query
    {
        OfReusability ofReusability;
        public MenuEcology(TelegConnect telegram) : base(telegram)
        {
            ofReusability = new OfReusability(telegram);

            questionForUser = telegram.Question.Ecology;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Reusability] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofReusability},
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu},

            };
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
