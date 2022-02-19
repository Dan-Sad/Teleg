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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.WhereClitor] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%клитор%'"),
                [telegram.Button.WhereVagina] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%вагина%'"),
                [telegram.Button.WhereAnus] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%анус%'"),
                [telegram.Button.WhereClitorVagina] = () => _telegram.sqlMes.Add("([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] LIKE '%вагина%')"),
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
