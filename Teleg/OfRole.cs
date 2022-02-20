using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfRole : Query
    {
        OfCouple ofCouple;
        public OfRole(TelegConnect telegram) : base(telegram)
        {
            ofCouple = new OfCouple(telegram);  

            questionForUser = telegram.Question.Role;
            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.RoleForCouples] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = ofCouple},
                [telegram.Button.RoleForDistant] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Control LIKE '%app%'")},
                [telegram.Button.RoleForSecret] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Role LIKE '%секрет%'")},
                [telegram.Button.RoleForSelf] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Role LIKE '%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
