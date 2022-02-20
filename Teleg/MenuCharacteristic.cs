using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuCharacteristic : Query
    {
        OfAllergy ofAllergy;
        OfLubricant ofLubricant;
        OfAggregate ofAggregate;
        OfSize ofSize;
        public MenuCharacteristic(TelegConnect telegram) : base(telegram)
        {
            ofAllergy = new OfAllergy(telegram);
            ofLubricant = new OfLubricant(telegram);
            ofAggregate = new OfAggregate(telegram);  
            ofSize = new OfSize(telegram); 

            questionForUser = telegram.Question.Characteristic;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Allergy] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofAllergy },
                [telegram.Button.Lubricant] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofLubricant },
                [telegram.Button.Agregate] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofAggregate },
                [telegram.Button.SizeOfHand] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofSize },
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu },

            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
