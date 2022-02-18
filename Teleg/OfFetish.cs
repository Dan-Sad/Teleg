using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfFetish : Query
    {
        public OfFetish(TelegConnect telegram, Query callerQuery, int countCalledButtons) : base(telegram, callerQuery, countCalledButtons)
        {
            questionForUser = telegram.Question.Fetish;
            buttons = new Dictionary<string, Method>()
            {
                
                [telegram.Button.FetishAnalSex] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishBDSM] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishBukaki] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishCuni] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishDoublePenetration] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishFeelPlenum] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishFillPlace] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishGameWithPartner] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishPetGame] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishPublicPlace] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishRealistic] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishSecretGame] = () => Console.WriteLine($"ToDo {questionForUser}"),
                [telegram.Button.FetishIntel] = () => Console.WriteLine($"ToDo {questionForUser}"),
            };
            _nextQuery = () => PushQuery(new OfRole(telegram, new OfFetish(telegram, callerQuery, countCalledButtons), _countCalledButtons));

            multipleCall = true;
            SpecificRealizing();

            BaseRealizing();
        }
    }
}
