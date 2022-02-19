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

            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Role] = () => _telegram.currentQuery = ofRole,
                [telegram.Button.Location] = () => _telegram.currentQuery = ofLocation,
                [telegram.Button.Fetish] = () => _telegram.currentQuery = ofFetish,
                [telegram.Button.TechniqueOfFap] = () => _telegram.currentQuery = ofTechniqueOfFap,
                [telegram.Button.Apply] = () => _telegram.currentQuery = _telegram.ofMenu,
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
