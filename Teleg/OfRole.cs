using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfRole : Query
    {
        MenuWishes menuWishes;
        OfCouple ofCouple;
        public OfRole(TelegConnect telegram) : base(telegram)
        {
            menuWishes = new MenuWishes(telegram);
            ofCouple = new OfCouple(telegram);  

            questionForUser = telegram.Question.Role;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.RoleForCouples] = () => _telegram.currentQuery = ofCouple,
                [telegram.Button.RoleForDistant] = () => _telegram.sqlMes.Add("Controle LIKE '%app%'"),
                [telegram.Button.RoleForSecret] = () => _telegram.sqlMes.Add("Role LIKE '%секрет%'"),
                [telegram.Button.RoleForSelf] = () => _telegram.sqlMes.Add("Role LIKE '%'"),
                [telegram.Button.Ready] = () => _telegram.currentQuery = menuWishes,
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
