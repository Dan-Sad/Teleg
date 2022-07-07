using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class Menu : Query
    {
        public MenuZona menuCharacteristic;
        public MenuStimul menuWishes;
        public MenuCover menuFeeling;
        public MenuEcology menuEcology;
        public MenuStyle menuStels;
        public MenuStates menuStates;
        public Menu(TelegConnect telegram) : base(telegram)
        {
            menuCharacteristic = new MenuZona(telegram);
            menuWishes = new MenuStimul(telegram);
            menuFeeling = new MenuCover(telegram);
            menuEcology = new MenuEcology(telegram);
            menuStels = new MenuStyle(telegram);
            menuStates = new MenuStates(telegram);

            Question = telegram.Question.Menu;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Characteristic] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuCharacteristic},
                [telegram.Button.Wishes] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuWishes},
                [telegram.Button.Feeling] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuFeeling},
                [telegram.Button.Ecology] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuEcology},
                [telegram.Button.Stels] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuStels},
                [telegram.Button.States] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuStates},
            };

            CreateButtonResult();  

            GenButtons();
        }
    }
}