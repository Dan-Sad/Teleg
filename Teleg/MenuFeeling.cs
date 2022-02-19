using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class MenuFeeling : Query
    {
        OfWhere ofWhere;
        OfTypeSimulation ofTypeSimulation;
        OfSensation ofSensation;
        OfMenu ofMenu;
        public MenuFeeling(TelegConnect telegram) : base(telegram)
        {
            ofWhere = new OfWhere(telegram);    
            ofTypeSimulation = new OfTypeSimulation(telegram);
            ofSensation = new OfSensation(telegram);    
            ofMenu = new OfMenu(telegram);  

            questionForUser = telegram.Question.Feeling;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Where] = () => _telegram.currentQuery = ofWhere,
                [telegram.Button.Stimulation] = () => _telegram.currentQuery = ofTypeSimulation,
                [telegram.Button.Sensation] = () => _telegram.currentQuery = ofSensation,
                [telegram.Button.Apply] = () => _telegram.currentQuery = ofMenu,
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
