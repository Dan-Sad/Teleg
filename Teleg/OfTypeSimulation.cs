using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTypeSimulation : Query
    {
        ComandChoose StimulationVacuum = new ComandChoose() { sqlRequest = "Vibration LIKE '%пульсация%'" };
        ComandChoose StimulationWave = new ComandChoose() { sqlRequest = "Vibration LIKE '%волнообразный%'" };
        ComandChoose StimulationRotation = new ComandChoose() { sqlRequest = "Vibration LIKE '%ротация%'" };
        public OfTypeSimulation(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Stimulation;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StimulationVacuum] = StimulationVacuum,
                [telegram.Button.StimulationWave] = StimulationWave,
                [telegram.Button.StimulationRotation] = StimulationRotation,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuFeeling},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
