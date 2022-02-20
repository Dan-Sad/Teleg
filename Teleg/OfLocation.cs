using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLocation : Query
    {
        public OfLocation(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Location;

            buttons = new Dictionary<string, ComandChoose>()
            {
                [telegram.Button.LocationBed] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Waterproof LIKE '%'")},
                [telegram.Button.LocationBath] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Waterproof LIKE '%IPX7%'")},
                [telegram.Button.LocationShower] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("(Waterproof LIKE '%IPX7%' OR Waterproof LIKE '%IPX6%')")},
                [telegram.Button.LocationSea] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Waterproof LIKE '%IPX7%'")},
                [telegram.Button.LocationPool] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Waterproof LIKE '%IPX7%'")},
                [telegram.Button.LocationPublic] = new ComandChoose() { ActionButton = () => _telegram.sqlMes.Add("Waterproof LIKE '%'")},
                [telegram.Button.Ready] = new ComandChoose() { ActionButton = () => _telegram.currentQuery = _telegram.ofMenu.menuWishes},
            };

            CreateButtonResullt();

            BaseRealizing();
        }
    }
}
