using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLikeon : Query
    {
        ComandChoose Space = new ComandChoose() { sqlRequest = "Role LIKE '%кольцо%'" };
        ComandChoose Usually = new ComandChoose() { sqlRequest = "Role LIKE '%кольцо%'" };
        ComandChoose Minimalism = new ComandChoose() { sqlRequest = "(Role LIKE '%параклитор%')" };
        ComandChoose Animal = new ComandChoose() { sqlRequest = "Role LIKE '%паравагина%'" };
        ComandChoose Stimpank = new ComandChoose() { sqlRequest = "Role LIKE '%параанал%'" };
        ComandChoose Child = new ComandChoose() { sqlRequest = "Role LIKE '%'" };
        ComandChoose Realistic = new ComandChoose() { sqlRequest = "Role LIKE '%'" };
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