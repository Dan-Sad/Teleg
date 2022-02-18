using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTechniqueOfFap : Query
    {
        public OfTechniqueOfFap(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Allergy;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.TechniqueOfFapMost] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%мост%'"),
                [telegram.Button.TechniqueOfFapRabbimg] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%раббинг%'"),
                [telegram.Button.TechniqueOfFapClitoris] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%клиторальная%'"),
                [telegram.Button.TechniqueOfFapAnus] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%анальная%'"),
                [telegram.Button.TechniqueOfFapVagPenet] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%вагинальная%'"),
                [telegram.Button.TechniqueOfFapTemp] = () => _telegram.sqlMes.Add("[Heat] LIKE '%да%'"),
                [telegram.Button.TechniqueOfFapHlopClitor] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%похлопывания%'"),
                [telegram.Button.TechniqueOfFapRoundVulva] = () => _telegram.sqlMes.Add("[Masturbation technique] LIKE '%круговая%'"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
