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
        public MenuFeeling(TelegConnect telegram) : base(telegram)
        {
            ofWhere = new OfWhere(telegram);    
            ofTypeSimulation = new OfTypeSimulation(telegram);
            ofSensation = new OfSensation(telegram);  

            questionForUser = telegram.Question.Feeling;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Where] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofWhere},
                [telegram.Button.Stimulation] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofTypeSimulation},
                [telegram.Button.Sensation] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofSensation},
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
