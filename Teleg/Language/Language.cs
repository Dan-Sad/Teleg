using System.Collections.Generic;

namespace Teleg
{
    class Language : Query
    {
        public Language(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Language;
            RegisterButton();
            GenButtons();
        }
        private void RegisterButton()
        {
            buttons = new Dictionary<string, ComandChoose>()
            {
                [_telegram.Button.LanguageRUS] = new ComandChoose() { ActionButton = () => SetLanguageRUS()},
                [_telegram.Button.LanguageENG] = new ComandChoose() { ActionButton = () => SetLanguageRUS()},//ENG
            };
        }
        private void SetLanguageENG()
        {
            _telegram.Question = new QuestionENG();
            _telegram.Button  = new ButtonENG();
            RegisterButton();
            _telegram.currentQuery = _telegram.Menu = new Menu(_telegram);
        }
        private void SetLanguageRUS()
        {
            _telegram.Question = new QuestionRUS();
            _telegram.Button = new ButtonRUS();
            RegisterButton();
            _telegram.currentQuery = _telegram.Menu = new Menu(_telegram);
        }
    }
}
