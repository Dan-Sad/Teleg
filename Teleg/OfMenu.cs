using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfMenu : Query
    {
        public MenuCharacteristic menuCharacteristic;
        public MenuWishes menuWishes;
        public MenuFeeling menuFeeling;
        public MenuEcology menuEcology;
        public MenuStels menuStels;
        public MenuSates menuSates;
        public OfMenu(TelegConnect telegram) : base(telegram)
        {
            menuCharacteristic = new MenuCharacteristic(telegram);
            menuWishes = new MenuWishes(telegram);
            menuFeeling = new MenuFeeling(telegram);
            menuEcology = new MenuEcology(telegram);
            menuStels = new MenuStels(telegram);
            menuSates = new MenuSates(telegram);

            questionForUser = telegram.Question.Menu;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Characteristic] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuCharacteristic},
                [telegram.Button.Wishes] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuWishes},
                [telegram.Button.Feeling] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuFeeling},
                [telegram.Button.Ecology] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuEcology},
                [telegram.Button.Stels] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuStels},
                [telegram.Button.States] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuSates},
            };

            CreateButtonResullt();  

            BaseRealizing();
        }
    }
}