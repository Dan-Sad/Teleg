using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfMenu : Query
    {
        MenuCharacteristic menuCharacteristic; 
        MenuWishes menuWishes;
        MenuFeeling menuFeeling;
        MenuEcology menuEcology;
        MenuStels menuStels;
        MenuSates menuSates;
        public OfMenu(TelegConnect telegram) : base(telegram)
        {
            menuCharacteristic = new MenuCharacteristic(telegram);
            menuWishes = new MenuWishes(telegram);
            menuFeeling = new MenuFeeling(telegram);
            menuEcology = new MenuEcology(telegram);
            menuStels = new MenuStels(telegram);
            menuSates = new MenuSates(telegram);

            questionForUser = telegram.Question.Menu;

            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Characteristic] = () => _telegram.currentQuery = menuCharacteristic,
                [telegram.Button.Wishes] = () => _telegram.currentQuery = menuWishes,
                [telegram.Button.Feeling] = () => _telegram.currentQuery = menuFeeling,
                [telegram.Button.Ecology] = () => _telegram.currentQuery = menuEcology,
                [telegram.Button.Stels] = () => _telegram.currentQuery = menuStels,
                [telegram.Button.States] = () => _telegram.currentQuery = menuSates,
            };

            CreateButtonResullt();  

            BaseRealizing();
        }
    }
}