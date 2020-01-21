﻿using Framework.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Models
{
    class Route
    {
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public string DateDeparture { get; set; }
        public string DepartureCityWithStation { get; set; }

        public string DepartureCityEmpty = string.Empty;

        public string ArrivalCityEmpty = string.Empty;
        public string PastDate { get; set; }
        public Route()
        {
            DepartureCityWithStation = GetRoute("DepartureCityWithStation");
            DepartureCity = GetRoute("DepartureCity");
            ArrivalCity = GetRoute("ArrivalCity");
            DateDeparture = GetRoute("DateDeparture");
            PastDate = GetRoute("PastDate");
        }
        string GetRoute(string key)
        {
<<<<<<< HEAD
            return TestDataReader.GetData(key);
=======
            return TestDataReader.GetData(key).Value;
>>>>>>> 897c223367cf0778ac7ea5d135c80743374718b9
        }
    }
}