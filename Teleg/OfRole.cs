using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfRole : Query
    {
        ComandChoose RoleForDistant = new ComandChoose() { sqlRequest = "Control LIKE '%app%'" };
        ComandChoose RoleForSecret = new ComandChoose() { sqlRequest = "Role LIKE '%секрет%'" };
        ComandChoose RoleForSelf = new ComandChoose() { sqlRequest = "Role LIKE '%'" };

        OfCouple ofCouple;
        public OfRole(TelegConnect telegram) : base(telegram)
        {
            ofCouple = new OfCouple(telegram);  

            questionForUser = telegram.Question.Role;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.RoleForCouples] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofCouple},
                [telegram.Button.RoleForDistant] = RoleForDistant,
                [telegram.Button.RoleForSecret] = RoleForSecret,
                [telegram.Button.RoleForSelf] = RoleForSelf,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuWishes},
            };

            CreateButtonResullt();
        }
    }
}
