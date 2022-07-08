using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLikeon : Query
    {
        ComandChoose Space = new ComandChoose() { sqlRequest = "Style LIKE '%космос%'" };
        ComandChoose Usually = new ComandChoose() { sqlRequest = "Style LIKE '%обычный%'" };
        ComandChoose Minimalism = new ComandChoose() { sqlRequest = "Style LIKE '%минимализм%'" };
        ComandChoose Animal = new ComandChoose() { sqlRequest = "Style LIKE '%животное%'" };
        ComandChoose Stimpank = new ComandChoose() { sqlRequest = "Style LIKE '%стимпанк%'" };
        ComandChoose Child = new ComandChoose() { sqlRequest = "Style LIKE '%детское%'" };
        ComandChoose Realistic = new ComandChoose() { sqlRequest = "Style LIKE '%реалистик%'" };
        public OfLikeon(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Likeon;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Space] = Space,
                [telegram.Button.Usually] = Usually,
                [telegram.Button.Minimalism] = Minimalism,
                [telegram.Button.Animal] = Animal,
                [telegram.Button.Child] = Child,
                [telegram.Button.Realistic] = Realistic,
                [telegram.Button.Stimpank] = Stimpank,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery =  _telegram.Menu.menuStyle},
            };

            CreateButtonResult();
        }
    }
}