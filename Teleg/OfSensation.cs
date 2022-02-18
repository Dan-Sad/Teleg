using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfSensation : Query
    {
        public OfSensation(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Allergy;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.SensationSoft] = () => _telegram.sqlMes.Add("Sensations LIKE '%Мягкость%'"),
                [telegram.Button.SensationHard] = () => _telegram.sqlMes.Add("Sensations LIKE '%Твердость%'"),
                [telegram.Button.SensationCold] = () => _telegram.sqlMes.Add("Sensations LIKE '%холод%'"),
                [telegram.Button.SensationMyTemperature] = () => _telegram.sqlMes.Add("Heat LIKE '%да%'"),
                [telegram.Button.SensationSmoothness] = () => _telegram.sqlMes.Add("Sensations LIKE '%гладкость%'"),
                [telegram.Button.SensationVelvety] = () => _telegram.sqlMes.Add("Sensations LIKE '%бархат%'"),
                [telegram.Button.SensationRealistic] = () => _telegram.sqlMes.Add("signs LIKE '%UR3%'"),
                [telegram.Button.SensationRelief] = () => _telegram.sqlMes.Add("Relief LIKE '%да%'"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
