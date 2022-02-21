﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfSensation : Query
    {
        ComandChoose SensationSoft = new ComandChoose() { sqlRequest = "Sensations LIKE '%Мягкость%'" };
        ComandChoose SensationHard = new ComandChoose() { sqlRequest = "Sensations LIKE '%Твердость%'" };
        ComandChoose SensationCold = new ComandChoose() { sqlRequest = "Sensations LIKE '%холод%'" };
        ComandChoose SensationMyTemperature = new ComandChoose() { sqlRequest = "Heat LIKE '%да%'" };
        ComandChoose SensationSmoothness = new ComandChoose() { sqlRequest = "Sensations LIKE '%гладкость%'" };
        ComandChoose SensationVelvety = new ComandChoose() { sqlRequest = "Sensations LIKE '%бархат%'" };
        ComandChoose SensationRealistic = new ComandChoose() { sqlRequest = "signs LIKE '%UR3%'" };
        ComandChoose SensationRelief = new ComandChoose() { sqlRequest = "Relief LIKE '%да%'" };
        public OfSensation(TelegConnect telegram) : base(telegram)
        {

            questionForUser = telegram.Question.Sensation;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.SensationSoft] = SensationSoft,
                [telegram.Button.SensationHard] = SensationHard,
                [telegram.Button.SensationCold] = SensationCold,
                [telegram.Button.SensationMyTemperature] = SensationMyTemperature,
                [telegram.Button.SensationSmoothness] = SensationSmoothness,
                [telegram.Button.SensationVelvety] = SensationVelvety,
                [telegram.Button.SensationRealistic] = SensationRealistic,
                [telegram.Button.SensationRelief] = SensationRelief,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuFeeling},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}
