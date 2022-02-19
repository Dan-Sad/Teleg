﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfStealthView : Query
    {
        MenuStels menuStels;
        public OfStealthView(TelegConnect telegram) : base(telegram)
        {
            menuStels = new MenuStels(telegram);

            questionForUser = telegram.Question.StealthView;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.StealthViewNoMatters] = () => _telegram.sqlMes.Add("[stealth view] LIKE '%нет%'"),
                [telegram.Button.StealthViewMatters] = () => _telegram.sqlMes.Add("[stealth view] LIKE '%да%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = menuStels,
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
