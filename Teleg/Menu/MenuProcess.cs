using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
     class MenuProcess : Query
    {
        ComandChoose Search = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Point = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose MixOrgasm = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Pillow = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose NewTech = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Boy = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Girl = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };
        ComandChoose Public = new ComandChoose() { sqlRequest = "[Type of stimulation] LIKE '%клитор%'" };

        public MenuProcess(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Wishes;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.Search] = Search,
                [telegram.Button.Point] = Point,
                [telegram.Button.MixOrgasm] = MixOrgasm,
                [telegram.Button.Pillow] = Pillow,
                [telegram.Button.NewTech] = NewTech,
                [telegram.Button.Boy] = Boy,
                [telegram.Button.Girl] = Girl,
                [telegram.Button.Public] = Public,
                [telegram.Button.Apply] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.Menu },
            };

            CreateButtonResult();

            GenButtons();
        }
    }
}