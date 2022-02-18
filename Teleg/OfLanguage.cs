using System.Collections.Generic;

namespace Teleg
{
    class OfLanguage : Query
    {
        public OfLanguage(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Language;
            RegisterButton();
            _nextQuery = () => PushQuery(new OfAllergy(telegram, this, 0));
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
        }
        private void SetLanguageRUS()
        {
            _telegram.Question = new QuestionRUS();
            _telegram.Button = new ButtonRUS();
            RegisterButton();
            BaseRealizing();
        }
    }
}
