using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTypeSimulation : Query
    {
        public OfTypeSimulation(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Stimulation;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.StimulationVacuum] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Vibration LIKE '%пульсация%'")},
                [telegram.Button.StimulationWave] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Vibration LIKE '%волнообразный%'")},
                [telegram.Button.StimulationRotation] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Vibration LIKE '%ротация%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuFeeling},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
