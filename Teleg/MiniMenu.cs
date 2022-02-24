using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Teleg
{
    class MiniMenu
    {
        public static void ProccesingUserMes(TelegConnect teleg, string messange)
        {
            Thread.Sleep(100);
            if (messange == "/restart")
            {
                teleg.TelegConnectRestart();
                teleg.currentQuery = new Language(teleg);
                teleg.DelAndSendQuery();
            }
            else if (messange == "/channel")
                teleg.SendMesAsync("[Пособие к руке](https://t.me/who_if_not_hand)");
            else
                teleg.DelAndSendQuery();
        }
    }
}
