using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfWhere : Query
    {
        public OfWhere(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Where;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.WhereClitor] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%клитор%'")},
                [telegram.Button.WhereVagina] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%вагина%'")},
                [telegram.Button.WhereAnus] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%анус%'")},
                [telegram.Button.WhereClitorVagina] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuFeeling},
            };

             CreateButtonResullt();

            BaseRealizing();
        }
    }
}
