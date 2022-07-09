using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg.Menu
{
     class MenuProcess : Query
    {
        ComandChoose Search = new ComandChoose() { sqlRequest = "Process LIKE '%поиск%'" };
        ComandChoose Point = new ComandChoose() { sqlRequest = "Process LIKE '%точечная%'" };
        ComandChoose MixOrgasm = new ComandChoose() { sqlRequest = "Process LIKE '%смешанный%'" };
        ComandChoose Pillow = new ComandChoose() { sqlRequest = "Process LIKE '%подушки%'" };
        ComandChoose NewTech = new ComandChoose() { sqlRequest = "signs LIKE '%приложение%'"   };
        ComandChoose Boy = new ComandChoose() { sqlRequest = "Process LIKE '%партнер%'"};
        ComandChoose Girl = new ComandChoose() { sqlRequest = "Process LIKE '%партнерка%'" };
        ComandChoose Public = new ComandChoose() { sqlRequest = "signs LIKE '%скрытое%'" };

        public MenuProcess(TelegConnect telegram) : base(telegram)
        {
            Question = telegram.Question.Process;
            sqlSeparator = " OR ";

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