using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuWishes : Query
    {
        public OfRole ofRole;
        OfLocation ofLocation;
        OfFetish ofFetish;
        OfTechniqueOfFap ofTechniqueOfFap;
        public MenuWishes(TelegConnect telegram) : base(telegram)
        {
            ofRole = new OfRole(telegram);
            ofLocation = new OfLocation(telegram);
            ofFetish = new OfFetish(telegram);
            ofTechniqueOfFap = new OfTechniqueOfFap(telegram);

            questionForUser = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Role] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofRole},
                [telegram.Button.Location] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofLocation},
                [telegram.Button.Fetish] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofFetish},
                [telegram.Button.TechniqueOfFap] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofTechniqueOfFap},
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
