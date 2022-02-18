﻿using System.Collections.Generic;

namespace Teleg
{
    class OfLanguage : Query
    {
        public OfLanguage(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Language;
            RegisterButton();
            BaseRealizing();
        }
        private void RegisterButton()
        {
            buttons = new Dictionary<string, Method>()
            {
                [_telegram.Button.LanguageRUS] = () => SetLanguageRUS(),
                [_telegram.Button.LanguageENG] = () => SetLanguageENG(),
            };
        }
        private void SetLanguageENG()
        {
            _telegram.Question = new QuestionENG();
            _telegram.Button  = new ButtonENG();
            RegisterButton();
            BaseRealizing();
            _telegram.currentQuery = new OfAllergy(_telegram);
        }
        private void SetLanguageRUS()
        {
            _telegram.Question = new QuestionRUS();
            _telegram.Button = new ButtonRUS();
            RegisterButton();
            BaseRealizing();
            _telegram.currentQuery = new OfAllergy(_telegram);
        }
    }
}
