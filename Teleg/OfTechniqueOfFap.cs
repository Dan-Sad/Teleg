using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTechniqueOfFap : Query
    {
        ComandChoose TechniqueOfFapMost = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%мост%'" };
        ComandChoose TechniqueOfFapRabbimg = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%раббинг%'" };
        ComandChoose TechniqueOfFapClitoris = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%клиторальная%'" };
        ComandChoose TechniqueOfFapAnus = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%анальная%'" };
        ComandChoose TechniqueOfFapVagPenet = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%вагинальная%'" };
        ComandChoose TechniqueOfFapTemp = new ComandChoose() { sqlRequest = "[Heat] LIKE '%да%'" };
        ComandChoose TechniqueOfFapHlopClitor = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%похлопывания%'" };
        ComandChoose TechniqueOfFapRoundVulva = new ComandChoose() { sqlRequest = "[Masturbation technique] LIKE '%круговая%'" };
        public OfTechniqueOfFap(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.TechniqueOfFap;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.TechniqueOfFapMost] = TechniqueOfFapMost,
                [telegram.Button.TechniqueOfFapRabbimg] = TechniqueOfFapRabbimg,
                [telegram.Button.TechniqueOfFapClitoris] = TechniqueOfFapClitoris,
                [telegram.Button.TechniqueOfFapAnus] = TechniqueOfFapAnus,
                [telegram.Button.TechniqueOfFapVagPenet] = TechniqueOfFapVagPenet,
                [telegram.Button.TechniqueOfFapTemp] = TechniqueOfFapTemp,
                [telegram.Button.TechniqueOfFapHlopClitor] = TechniqueOfFapHlopClitor,
                [telegram.Button.TechniqueOfFapRoundVulva] = TechniqueOfFapRoundVulva,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
