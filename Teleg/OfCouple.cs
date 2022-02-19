using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfCouple : Query
    {
        public OfCouple(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Couple;

            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.CoupleStopPenis] = () => _telegram.sqlMes.Add("Role LIKE '%кольцо%'"),
                [telegram.Button.CoupleLongSex] = () => _telegram.sqlMes.Add("Role LIKE '%кольцо%'"),
                [telegram.Button.CoupleClitor] = () => _telegram.sqlMes.Add("([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] NOT LIKE '%вагина%' AND [Type of stimulation] NOT LIKE '%анус%')"),
                [telegram.Button.CoupleVagina] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%вагина%'"),
                [telegram.Button.CoupleAnus] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%анус%'"),
                [telegram.Button.CoupleOtherZone] = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes.ofRole,
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
