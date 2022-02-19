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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Allergy] = () => _telegram.currentQuery = ofAllergy,
                [telegram.Button.Lubricant] = () => _telegram.currentQuery = ofLubricant,
                [telegram.Button.Agregate] = () => _telegram.currentQuery = ofAggregate,
                [telegram.Button.SizeOfHand] = () => _telegram.currentQuery = ofSize,
                [telegram.Button.Apply] = () => _telegram.currentQuery = _telegram.ofMenu,

            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
