using System;
using System.Collections.Generic;
using Telegram.Bot;

namespace Teleg
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = "5161443212:AAH8HpmkdR-ioACPy1hZEDWzhFAiLwykhNk";
            var bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();

            
            
            Console.Read();
            
            
            //new ModylQuestions();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
        }
    }
}
