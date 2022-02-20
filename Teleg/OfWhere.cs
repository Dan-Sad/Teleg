using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfWhere : Query
    {
        ComandChoose WhereClitor = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose WhereVagina = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose WhereAnus = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
        ComandChoose WhereClitorVagina = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')" };
        public OfWhere(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Where;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.WhereClitor] = WhereClitor,
                [telegram.Button.WhereVagina] = WhereVagina,
                [telegram.Button.WhereAnus] = WhereAnus,
                [telegram.Button.WhereClitorVagina] = WhereClitorVagina,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuFeeling},
            };

             CreateButtonResullt();

            BaseRealizing();
        }
    }
}
