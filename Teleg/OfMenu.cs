using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfMenu : Query
    {
        OfAggregate ofAggregate;
        OfAllergy ofAllergy;
        public OfMenu(TelegConnect telegram) : base(telegram)
        {
            ofAggregate = new OfAggregate(_telegram);
            ofAllergy = new OfAllergy(_telegram);
            questionForUser = telegram.Question.Menu;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Characteristic] = () => _telegram.currentQuery = ofAllergy,
                [telegram.Button.Wishes] = () => _telegram.currentQuery = new OfAllergy(_telegram),
                [telegram.Button.Feeling] = () => _telegram.currentQuery = new OfAllergy(_telegram),
                [telegram.Button.Ecology] = () => _telegram.currentQuery = new OfAllergy(_telegram),
                [telegram.Button.Stels] = () => _telegram.currentQuery = new OfAllergy(_telegram),
                [telegram.Button.States] = () => _telegram.currentQuery = new OfAllergy(_telegram),
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
