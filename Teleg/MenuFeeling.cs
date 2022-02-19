using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuFeeling
    {

        public MenuFeeling(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Feeling;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Where] = () => _telegram.sqlMes.Add("Sensations LIKE '%Мягкость%'"),
                [telegram.Button.Stimulation] = () => _telegram.sqlMes.Add("Sensations LIKE '%Твердость%'"),
                [telegram.Button.Sensation] = () => _telegram.sqlMes.Add("Sensations LIKE '%холод%'"),
            };

            multipleCall = false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
