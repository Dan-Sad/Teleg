using System.Collections.Generic;

namespace Teleg
{
    class OfLanguage : Query
    {
        public OfLanguage(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Language;
            RegisterButton();
            GenButtons();
        }
        private void RegisterButton()
        {
            buttons = new Dictionary<string, ComandChoose>()
            {
                [_telegram.Button.LanguageRUS] = new ComandChoose() { ActionButton = () => SetLanguageRUS()},
                [_telegram.Button.LanguageENG] = new ComandChoose() { ActionButton = () => SetLanguageENG()},
            };
        }
        private void SetLanguageENG()
        {
            _telegram.Question = new QuestionENG();
            _telegram.Button  = new ButtonENG();
            RegisterButton();
            GenButtons();
            _telegram.currentQuery = _telegram.ofMenu = new OfMenu(_telegram);
        }
        private void SetLanguageRUS()
        {
            _telegram.Question = new QuestionRUS();
            _telegram.Button = new ButtonRUS();
            RegisterButton();
            GenButtons();
            _telegram.currentQuery = _telegram.ofMenu = new OfMenu(_telegram);
        }
    }
}
