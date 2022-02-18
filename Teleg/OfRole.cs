using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfRole : Query
    {
        int i = 0;
        public OfRole(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Role;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.RoleForCouples] = () => _telegram.sqlMes.Add("(Role LIKE '%пара%' OR Controle LIKE '%app%')"),//
                [telegram.Button.RoleForDistant] = () => _telegram.sqlMes.Add("Controle LIKE '%app%'"),
                [telegram.Button.RoleForSecret] = () => _telegram.sqlMes.Add("Role LIKE '%секрет%'"),
                [telegram.Button.RoleForSelf] = () => _telegram.sqlMes.Add("Role LIKE '%'"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
