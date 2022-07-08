using System;
using System.Collections.Generic;
using System.Text;
using Teleg.Menu;

namespace Teleg
{
    class MainMenu : Query
    {
        public MenuZona menuZona;
        public MenuStimul menuStimul;
        public MenuCover menuCover;
        public MenuEcology menuEcology;
        public MenuStyle menuStyle;
        public MenuStates menuStates;
        public MenuFeels menuFeels;
        public MenuFourty menuFourty;
        public MenuLimit menuLimit;
        public MenuProcess menuProcess;
        public MainMenu(TelegConnect telegram) : base(telegram)
        {
            menuZona = new MenuZona(telegram);
            menuStimul = new MenuStimul(telegram);
            menuCover = new MenuCover(telegram);
            menuEcology = new MenuEcology(telegram);
            menuStyle = new MenuStyle(telegram);
            menuStates = new MenuStates(telegram);
            menuFeels = new MenuFeels(telegram);
            menuFourty = new MenuFourty(telegram);
            menuLimit = new MenuLimit(telegram);
            menuProcess = new MenuProcess(telegram);

            Question = telegram.Question.Menu;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Zona] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuZona },
                [telegram.Button.Stimul] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuStimul },
                [telegram.Button.Cover] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuCover },
                [telegram.Button.Ecology] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuEcology},
                [telegram.Button.Style] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuStyle },
                [telegram.Button.States] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuStates},
                [telegram.Button.Feels] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuFeels },
                [telegram.Button.Fourty] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuFourty },
                [telegram.Button.Limit] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuLimit },
                [telegram.Button.Process] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = menuProcess },
            };

            CreateButtonResult();  

            GenButtons();
        }
    }
}