using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfMenu : Query
    {
        public OfMenu(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Allergy;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Question.Allergy] = () => _telegram.currentQuery = new OfAllergy(_telegram),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}