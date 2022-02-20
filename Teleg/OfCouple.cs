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

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.CoupleStopPenis] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Role LIKE '%кольцо%'")},
                [telegram.Button.CoupleLongSex] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Role LIKE '%кольцо%'")},
                [telegram.Button.CoupleClitor] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("([Type of stimulation] LIKE '%клитор%' AND [Type of stimulation] NOT LIKE '%вагина%' AND [Type of stimulation] NOT LIKE '%анус%')")},
                [telegram.Button.CoupleVagina] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%вагина%'")},
                [telegram.Button.CoupleAnus] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%анус%'")},
                [telegram.Button.CoupleOtherZone] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Type of stimulation] LIKE '%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes.ofRole},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
