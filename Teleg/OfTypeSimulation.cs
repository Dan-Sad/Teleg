using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTypeSimulation : Query
    {
        MenuFeeling menuFeeling;
        public OfTypeSimulation(TelegConnect telegram) : base(telegram)
        {
            menuFeeling = new MenuFeeling(telegram);   

            questionForUser = telegram.Question.Stimulation;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StimulationVacuum] = () => _telegram.sqlMes.Add("Vibration LIKE '%пульсация%'"),
                [telegram.Button.StimulationWave] = () => _telegram.sqlMes.Add("Vibration LIKE '%волнообразный%'"),
                [telegram.Button.StimulationRotation] = () => _telegram.sqlMes.Add("Vibration LIKE '%ротация%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = menuFeeling,
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
