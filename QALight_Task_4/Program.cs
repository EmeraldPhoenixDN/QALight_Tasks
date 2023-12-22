using System;
using System.Collections.Generic;

namespace QALight_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new Weather(42, "Alicante", 15);

            weather.CheckWeather(false, true);

            weather.CelebrateHoliday(Weather.Holidays.NewYear);

            int[] numbers = { 15, 9, 44, 6, 14, 7, 8 };
            weather.NumberTypeForeach(numbers);

            weather.NumberTypeFor(numbers);

            Dictionary<string, string> capitals = new Dictionary<string, string>
        {
            { "Ukraine", "Kyiv" },
            { "Spain", "Madrid" },
            { "Canada", "Ottawa" }
        };

            weather.CountyAndCapital(capitals);
        }
    }
    }

