using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    internal class MenuWishes : Query
    {

        public MenuWishes(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Wishes;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.Role] = () => _telegram.sqlMes.Add("Sensations LIKE '%Мягкость%'"),
                [telegram.Button.Location] = () => _telegram.sqlMes.Add("Sensations LIKE '%Твердость%'"),
                [telegram.Button.Fetish] = () => _telegram.sqlMes.Add("Sensations LIKE '%холод%'"),
                [telegram.Button.TechniqueOfFap] = () => _telegram.sqlMes.Add("Heat LIKE '%да%'"),
            };

            multipleCall =false;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
