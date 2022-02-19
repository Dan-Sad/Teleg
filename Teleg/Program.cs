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
            string token = "5161443212:AAEv9OdF14ysgm4C1dAkM8cN0pwBuSdo6IE";
            bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.OnCallbackQuery += Bot_OnCallbackQuery;
            bot.StartReceiving();

            Console.Read();
        }

        private static async void Bot_OnCallbackQuery(object sender, CallbackQueryEventArgs callbackEvent)
        {
            long curUserID = callbackEvent.CallbackQuery.From.Id;
            foreach (var user in users)
            {
                if (curUserID == user.Key)
                {
                    user.Value.PushData(callbackEvent);
                    user.Value.haveNewCallback = true;

                    user.Value.CallQuery();

                    return;
                }
            }
        }

        private async static void Bot_OnMessage(object sender, MessageEventArgs mesEvent)
        {
            long curUserID = mesEvent.Message.From.Id;

            foreach (var user in users)
            {
                if (curUserID == user.Key)
                {
                    user.Value.PushData(mesEvent.Message.Chat.Id, mesEvent);
                    user.Value.haveNewMessage = true;
                    return;
                }
            }

            TelegConnect telegramConnect = new TelegConnect(mesEvent.Message.Chat.Id, mesEvent);
            users.Add(curUserID, telegramConnect);
        }
    }
}