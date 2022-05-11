using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfCouple : Query
    {
        ComandChoose CoupleStopPenis = new ComandChoose() { sqlRequest = "Role LIKE '%кольцо%'" };
        ComandChoose CoupleLongSex = new ComandChoose() { sqlRequest = "Role LIKE '%кольцо%'" };
        ComandChoose CoupleClitor = new ComandChoose() { sqlRequest = "(Role LIKE '%параклитор%')" };
        ComandChoose CoupleVagina = new ComandChoose() { sqlRequest = "Role LIKE '%паравагина%'" };
        ComandChoose CoupleAnus = new ComandChoose() { sqlRequest = "Role LIKE '%параанал%'" };
        ComandChoose CoupleOtherZone = new ComandChoose() { sqlRequest = "Role LIKE '%'" };
        public OfCouple(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Couple;

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

            CreateButtonResult();
        }
    }
}
