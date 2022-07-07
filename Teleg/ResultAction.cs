using System;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Teleg
{
    class ResultAction
    {
        private int currentIndex;
        private int maxIndex;
        private List<DataSQL> resultData;
        private DataSQL currentData;
        private InlineKeyboardMarkup keyboard;
        private TelegConnect _telegram;

        public static string Back { get; } = "BackResult";
        public static string Next { get; } = "NextResult";
        private static string First { get; } = "First";

        public ResultAction(TelegConnect telegram)
        {
            resultData = telegram.GetDataOfSQL(telegram.currentQuery.GenerateSqlMessange(forCount: false));

            currentIndex = 0;
            maxIndex = resultData.Count - 1;
            _telegram = telegram;

            var buttons = new Dictionary<string, ComandChoose>();

            keyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    new InlineKeyboardButton(){Text = telegram.Button.Return, CallbackData = Back},
                    new InlineKeyboardButton(){Text = telegram.Button.Next, CallbackData = Next},
                }
            });

            ActionCallback(First);
        }

        public void ActionCallback(string callbackData)
        {
            if (currentIndex != maxIndex && callbackData == Next)
                currentIndex++;
            else if (currentIndex != 0 && callbackData == Back)
                currentIndex--;

           _telegram.DelLastSentMes();

            currentData = resultData[currentIndex];

            string textForSend = "*" + currentData.Name + "*" + $"\n" + currentData.Description;

            if (currentData.Picture != null)
                _telegram.SendPhotoAsync(currentData.Picture, textForSend, keyboard);
            else
                _telegram.SendMesAsync(textForSend, keyboard);
        }
    }
}
