using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class Buttons
    {
        public string Text { get; set; }
        public Method Action { get; set; }
        public bool Chosen { get; set; }
        public void Add(string textOnButton, Method actionButton, bool chooseButton)
        {
            Text = textOnButton;
            Action = actionButton;
            Chosen = chooseButton;
        }
    }
}
