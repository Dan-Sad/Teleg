using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class ComandChoose
    {
        public Method ActionButton;
        public string sqlRequest { get; set; }
        public bool Chosen { get; set; }

        public ComandChoose()
        {
            Chosen = false;
        }
        public void ReChoose() => Chosen = !Chosen;
        public void SqlPushOrDell(TelegConnect teleg)
        {
            if (Chosen)
            {
                teleg.sqlMes.Remove(sqlRequest);
            }
            else
            {
                teleg.sqlMes.Add(sqlRequest);
            }
            ReChoose();
        }
    }
}
