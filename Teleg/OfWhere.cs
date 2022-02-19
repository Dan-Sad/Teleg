using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfWhere : Query
    {
        MenuFeeling menuFeeling;
        public OfWhere(TelegConnect telegram) : base(telegram)
        {
            menuFeeling = new MenuFeeling(telegram);

            questionForUser = telegram.Question.Where;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.WhereClitor] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%клитор%'"),
                [telegram.Button.WhereVagina] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%вагина%'"),
                [telegram.Button.WhereAnus] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%анус%'"),
                [telegram.Button.WhereClitorVagina] = () => _telegram.sqlMes.Add("([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = menuFeeling,
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
