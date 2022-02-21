using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLocation : Query
    {
        ComandChoose LocationBed = new ComandChoose() { sqlRequest = "Waterproof LIKE '%'" };
        ComandChoose LocationBath = new ComandChoose() { sqlRequest = "([Waterproof] > 6 )" };
        ComandChoose LocationShower = new ComandChoose() { sqlRequest = "([Waterproof] >= 6 )" };
        ComandChoose LocationSea = new ComandChoose() { sqlRequest = "([Waterproof] > 6 )" };
        ComandChoose LocationPool = new ComandChoose() { sqlRequest = "([Waterproof] > 6 )" };
        ComandChoose LocationPublic = new ComandChoose() { sqlRequest = "(Waterproof LIKE '%' AND [Role] LIKE '%секрет%')"  };
        public OfLocation(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Location;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.LocationBed] = LocationBed,
                [telegram.Button.LocationBath] = LocationBath,
                [telegram.Button.LocationShower] = LocationShower,
                [telegram.Button.LocationSea] = LocationSea,
                [telegram.Button.LocationPool] = LocationPool,
                [telegram.Button.LocationPublic] = LocationPublic,
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes},
            };

            CreateButtonResullt();

            GenButtons();
        }
    }
}