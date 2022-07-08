using System;
using System.Collections.Generic;

namespace Teleg
{
    class OfColor : Query
    {
        ComandChoose White = new ComandChoose() { sqlRequest = "Material NOT LIKE '%силикон%'" };
        ComandChoose Green = new ComandChoose() { sqlRequest = "Material NOT LIKE '%латекс%'" };
        ComandChoose Black = new ComandChoose() { sqlRequest = "Material NOT LIKE '%Bioskin%'" };
        ComandChoose Red = new ComandChoose() { sqlRequest = "Material NOT LIKE '%TPR%'" };
        ComandChoose Blue = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
        ComandChoose Yellow = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Gray = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Pink  = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Violent = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Dark = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Metal = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Light = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Gentle = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
         ComandChoose Bright = new ComandChoose() { sqlRequest = "Material NOT LIKE '%ABS%'" };
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