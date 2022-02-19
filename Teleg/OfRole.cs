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
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.RoleForCouples] = () => _telegram.currentQuery = ofCouple,
                [telegram.Button.RoleForDistant] = () => _telegram.sqlMes.Add("Control LIKE '%app%'"),
                [telegram.Button.RoleForSecret] = () => _telegram.sqlMes.Add("Role LIKE '%секрет%'"),
                [telegram.Button.RoleForSelf] = () => _telegram.sqlMes.Add("Role LIKE '%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes,
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
