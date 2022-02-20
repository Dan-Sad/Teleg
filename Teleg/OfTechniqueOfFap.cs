using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTechniqueOfFap : Query
    {
        public OfTechniqueOfFap(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.TechniqueOfFap;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.TechniqueOfFapMost] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%мост%'")},
                [telegram.Button.TechniqueOfFapRabbimg] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%раббинг%'")},
                [telegram.Button.TechniqueOfFapClitoris] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%клиторальная%'")},
                [telegram.Button.TechniqueOfFapAnus] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%анальная%'")},
                [telegram.Button.TechniqueOfFapVagPenet] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%вагинальная%'")},
                [telegram.Button.TechniqueOfFapTemp] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Heat] LIKE '%да%'")},
                [telegram.Button.TechniqueOfFapHlopClitor] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%похлопывания%'")},
                [telegram.Button.TechniqueOfFapRoundVulva] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%круговая%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
