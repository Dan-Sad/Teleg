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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StimulationVacuum] = () => _telegram.sqlMes.Add("Vibration LIKE '%пульсация%'"),
                [telegram.Button.StimulationWave] = () => _telegram.sqlMes.Add("Vibration LIKE '%волнообразный%'"),
                [telegram.Button.StimulationRotation] = () => _telegram.sqlMes.Add("Vibration LIKE '%ротация%'"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
