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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Reusability] = () => _telegram.currentQuery = ofReusability,
                [telegram.Button.Apply] = () => _telegram.currentQuery = _telegram.ofMenu,

            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
