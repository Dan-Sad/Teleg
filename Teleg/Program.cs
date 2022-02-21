using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace Teleg
{
    class Teleg
    {
        public static TelegramBotClient bot;
        static Dictionary<long, TelegConnect> chats = new Dictionary<long, TelegConnect>();
        static void Main(string[] args)
        {
            //TelegConnect teleg = new TelegConnect(11, new MessageEventArgs(new Telegram.Bot.Types.Message()));
            //OfMenu ofMenu = new OfMenu(teleg);
            string token = "5161443212:AAEv9OdF14ysgm4C1dAkM8cN0pwBuSdo6IE";
            bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.OnCallbackQuery += Bot_OnCallbackQuery;
            bot.StartReceiving();

            Task task = new Task(() => { while (true) Thread.Sleep(10000); });
            task.Start();
            task.Wait();
        }

        private static async void Bot_OnCallbackQuery(object sender, CallbackQueryEventArgs callbackEvent)
        {
            long curChatID = callbackEvent.CallbackQuery.Message.Chat.Id;
            foreach (var chat in chats)
            {
                if (curChatID == chat.Key)
                {
                    chat.Value.PushData(callbackEvent);
                    chat.Value.haveNewCallback = true;

                    chat.Value.CallQuery();

                    bot.AnswerCallbackQueryAsync(callbackEvent.CallbackQuery.Id);

                    return;
                }
            }
        }

        private async static void Bot_OnMessage(object sender, MessageEventArgs mesEvent)
        {
            long curChatID = mesEvent.Message.Chat.Id;

            foreach (var chat in chats)
            {
                if (curChatID == chat.Key)
                {
                    chat.Value.PushData(mesEvent.Message.Chat.Id, mesEvent);
                    chat.Value.haveNewMessage = true;
                    chat.Value.SendQuery();
                    return;
                }
            }

            TelegConnect telegramConnect = new TelegConnect(mesEvent.Message.Chat.Id, mesEvent);
            chats.Add(curChatID, telegramConnect);
        }
    }
}