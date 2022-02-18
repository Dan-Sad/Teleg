using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace Teleg
{
    class Teleg
    {
        public static TelegramBotClient bot;
        static Dictionary<long, TelegConnect> users = new Dictionary<long, TelegConnect>();
        static void Main(string[] args)
        {
            string token = "5161443212:AAH07mKLSet-JG_7z7cpdOtvoTMe-vhEbgs";
            bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();

            Console.Read();
        }

        private async static void Bot_OnMessage(object sender, MessageEventArgs eventArg)
        {
            long curUserID = eventArg.Message.From.Id;
            foreach (var user in users)
            {
                if (curUserID == user.Key)
                {
                    user.Value.PushDate(eventArg.Message.Chat.Id, eventArg);
                    user.Value.haveNewMessage = true;
                    return;
                }
            }
            TelegConnect telegramConnect = new TelegConnect(eventArg.Message.Chat.Id, eventArg);
            users.Add(curUserID, telegramConnect);
        }
    }
}
