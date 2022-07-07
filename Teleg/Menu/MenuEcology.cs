using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuEcology : Query
    {
        ComandChoose Battery = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Vegan = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose Factory = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
       
        public MenuEcology(TelegConnect telegram) : base(telegram)
        {

            Question = telegram.Question.Ecology;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Battery] = Battery,
                [telegram.Button.Vegan] = Vegan,
                [telegram.Button.Factory] = Factory,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu},

            };
            CreateButtonResult();

            GenButtons();
        }
    }
}
