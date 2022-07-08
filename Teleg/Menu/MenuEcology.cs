using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuEcology : Query
    {
        ComandChoose Battery = new ComandChoose() { sqlRequest = "Accumul LIKE '%да%'" };
        ComandChoose Vegan = new ComandChoose() { sqlRequest = "Vegan LIKE '%да%'" };
        ComandChoose Factory = new ComandChoose() { sqlRequest = "[Care factory] LIKE '%да%'" };
       
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
