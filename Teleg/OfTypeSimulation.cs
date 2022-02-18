using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfTypeSimulation : Query
    {
        public OfTypeSimulation(TelegConnect telegram, Query callerQuery, int countCalledButtons) : base(telegram, callerQuery, countCalledButtons)
        {
            questionForUser = telegram.Question.Stimulation;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.RoleForCouples] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.RoleForDouble] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.RoleForSecret] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.RoleForSelf] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationVacuum] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationWave] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationVagina] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationClitor] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationMechanical] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationRotation] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.StimulationAnus] = () => Console.WriteLine($"ToDo {questionForUser}"),
            };
            _nextQuery = () => PushQuery(new OfTypeSimulation(telegram, new OfTypeSimulation(telegram, callerQuery, countCalledButtons), _countCalledButtons));

            multipleCall = true;
            SpecificRealizing();

            BaseRealizing();
        }
    }
}
