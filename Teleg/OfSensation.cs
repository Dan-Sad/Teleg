using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfSensation : Query
    {
        public OfSensation(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Sensation;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.SensationSoft] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Sensations LIKE '%Мягкость%'")},
                [telegram.Button.SensationHard] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Sensations LIKE '%Твердость%'")},
                [telegram.Button.SensationCold] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Sensations LIKE '%холод%'")},
                [telegram.Button.SensationMyTemperature] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Heat LIKE '%да%'")},
                [telegram.Button.SensationSmoothness] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Sensations LIKE '%гладкость%'")},
                [telegram.Button.SensationVelvety] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Sensations LIKE '%бархат%'")},
                [telegram.Button.SensationRealistic] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("signs LIKE '%UR3%'")},
                [telegram.Button.SensationRelief] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Relief LIKE '%да%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuFeeling},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
