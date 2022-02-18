using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLubricant : Query
    {
        public OfLubricant(TelegConnect telegram, Query callerQuery, int countCalledButtons) : base(telegram, callerQuery, countCalledButtons)
        {
            questionForUser = telegram.Question.Lubricant;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.LibricantWater] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.LibricantSilicon] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.LibricantOily] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.LibricantWaterOily] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.LibricantWaterSilicon] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.LibricantNoMatters] = () => Console.WriteLine($"ToDo {questionForUser}"),
            };
            _nextQuery = () => PushQuery(new OfFetish(telegram, new OfLubricant(telegram, callerQuery, countCalledButtons), _countCalledButtons));

            multipleCall = true;
            SpecificRealizing();

            BaseRealizing();
        }
    }
}
