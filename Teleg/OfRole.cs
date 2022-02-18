using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfRole : Query
    {
        int i = 0;
        public OfRole(TelegConnect telegram, Query callerQuery, int countCalledButtons) : base(telegram, callerQuery, countCalledButtons)
        {
            questionForUser = telegram.Question.Role;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.RoleForCouples] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.RoleForDouble] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.RoleForSecret] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.RoleForSelf] = () => Console.WriteLine($"ToDo {questionForUser}"),
            };
            _nextQuery = () => PushQuery(new OfTypeSimulation(telegram, new OfRole(telegram, callerQuery, countCalledButtons), _countCalledButtons));

            multipleCall = true;
            SpecificRealizing();

            BaseRealizing();
        }
    }
}
