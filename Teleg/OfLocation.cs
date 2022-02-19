﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class OfLocation : Query
    {
        public OfLocation(TelegConnect telegram) : base(telegram)
        {
            questionForUser = telegram.Question.Location;
            buttons = new Dictionary<string, Method>()
            {
                [telegram.Button.LocationBed] = () => _telegram.sqlMes.Add("Waterproof LIKE '%'"),
                [telegram.Button.LocationBath] = () => _telegram.sqlMes.Add("Waterproof LIKE '%IPX7%'"),
                [telegram.Button.LocationShower] = () => _telegram.sqlMes.Add("(Waterproof LIKE '%IPX7%' OR Waterproof LIKE '%IPX6%')"),
                [telegram.Button.LocationSea] = () => _telegram.sqlMes.Add("Waterproof LIKE '%IPX7%'"),
                [telegram.Button.LocationPool] = () => _telegram.sqlMes.Add("Waterproof LIKE '%IPX7%'"),
                [telegram.Button.LocationPublic] = () => _telegram.sqlMes.Add("Waterproof LIKE '%'"),
            };

            multipleCall = true;
            CreateButtonResullt();

            BaseRealizing();
        }
    }
}