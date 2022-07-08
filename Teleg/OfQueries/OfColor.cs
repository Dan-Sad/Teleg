using System;
using System.Collections.Generic;

namespace Teleg
{
    class OfColor : Query
    {
        ComandChoose White = new ComandChoose() { sqlRequest = "Color NOT LIKE '%белый%'" };
        ComandChoose Green = new ComandChoose() { sqlRequest = "Color NOT LIKE '%зеленый%'" };
        ComandChoose Black = new ComandChoose() { sqlRequest = "Color NOT LIKE '%черный%'" };
        ComandChoose Red = new ComandChoose() { sqlRequest = "Color NOT LIKE '%красный%'" };
        ComandChoose Blue = new ComandChoose() { sqlRequest = "Color NOT LIKE '%голубой%'" };
        ComandChoose Yellow = new ComandChoose() { sqlRequest = "Color NOT LIKE '%желтый%'"  };
         ComandChoose Gray = new ComandChoose() { sqlRequest = "Color NOT LIKE '%серый%'" };
         ComandChoose Pink  = new ComandChoose() { sqlRequest = "Color NOT LIKE '%розовый%'" };
         ComandChoose Violent = new ComandChoose() { sqlRequest = "Color NOT LIKE '%фиолетовый%'" };
         ComandChoose Dark = new ComandChoose() { sqlRequest = "Color NOT LIKE '%темный%'" };
         ComandChoose Metal = new ComandChoose() { sqlRequest = "Color NOT LIKE '%металл%'" };
         ComandChoose Light = new ComandChoose() { sqlRequest = "Color NOT LIKE '%светлый%'" };
         ComandChoose Gentle = new ComandChoose() { sqlRequest = "Color NOT LIKE '%нежный%'" };
         ComandChoose Bright = new ComandChoose() { sqlRequest = "Color NOT LIKE '%яркий%'" };
        public OfColor(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Color;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.White] = White,
                [telegram.Button.Black] = Black,
                [telegram.Button.Red] = Red,
                [telegram.Button.Green] = Green,
                [telegram.Button.Blue] = Blue,
                [telegram.Button.Yellow] = Yellow,
                [telegram.Button.Gray] = Gray,
                [telegram.Button.Pink] =  Pink,
                [telegram.Button.Violent] = Violent,
                [telegram.Button.Dark] = Dark,
                [telegram.Button.Metal] = Metal,
                [telegram.Button.Light] = Light,
                [telegram.Button.Gentle] = Gentle,
                [telegram.Button.Bright] = Bright,
                
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu.menuStyle },
            };

            CreateButtonResult();
        }
    }
}