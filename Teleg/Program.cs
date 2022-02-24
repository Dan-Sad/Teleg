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
            string token = "5272306545:AAHa0Ul9vPeUu8wPMeKA4Ed0djhKwOxxG8g";
            bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.OnCallbackQuery += Bot_OnCallbackQuery;
            bot.StartReceiving();


            Task task = new Task(() => { while (true) { Thread.Sleep(30000); Console.WriteLine($"{DateTime.Now} : {chats.Count}"); } });
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

                    await Task.Run(() => chat.Value.CallQuery());

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

                    MiniMenu.ProccesingUserMes(chat.Value, mesEvent.Message.Text);

                    return;
                }
            }

            TelegConnect telegramConnect = new TelegConnect(mesEvent.Message.Chat.Id, mesEvent);
            chats.Add(curChatID, telegramConnect);
        }
    }
}