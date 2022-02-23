using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfCouple : Query
    {
        ComandChoose CoupleStopPenis = new ComandChoose() { sqlRequest = "Role LIKE '%кольцо%'" };
        ComandChoose CoupleLongSex = new ComandChoose() { sqlRequest = "Role LIKE '%кольцо%'" };
        ComandChoose CoupleClitor = new ComandChoose() { sqlRequest = "([Type of stimulation] LIKE '%клитор%')" };
        ComandChoose CoupleVagina = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%вагина%'" };
        ComandChoose CoupleAnus = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%анус%'" };
        ComandChoose CoupleOtherZone = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%'" };
        public OfCouple(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Couple;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.CoupleStopPenis] = CoupleStopPenis,
                [telegram.Button.CoupleLongSex] = CoupleLongSex,
                [telegram.Button.CoupleClitor] = CoupleClitor,
                [telegram.Button.CoupleVagina] = CoupleVagina,
                [telegram.Button.CoupleAnus] = CoupleAnus,
                [telegram.Button.CoupleOtherZone] = CoupleOtherZone,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.queries[_telegram.Question.Role]},
            };

            CreateButtonResullt();
        }
    }
}
