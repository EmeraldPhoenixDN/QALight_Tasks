using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_Task_4
{
    class Weather
    {
        public int Temperature { get; set; }
        public string City { get; set; }
        public const double MinTemperature = -15.5;
        private readonly double _currentTemperature;

        public Weather(int temperature, string city, double currentTemperature)
        {
            Temperature = temperature;
            City = city;
            _currentTemperature = currentTemperature; 

        }

        // 2
        public void CheckWeather(bool isRainy, bool isSunny)
        {
            if (isRainy || !isSunny)
            {
                Console.WriteLine("Let`s take an umbrella.");
            }

            else if (!isRainy || isSunny)
            {
                Console.WriteLine("Let`s take sunglasses.");
            }

            else if (isSunny && isRainy)
            {
                Console.WriteLine("Let`s take an umbrella and sunglasses.");
            }
            
        }

        //3
        public enum Holidays
        {
            Birthday,
            Christmas,
            NewYear
        }

        public void CelebrateHoliday(Holidays holiday)
        {
            switch (holiday)
            {
                case Holidays.Birthday:
                    Console.WriteLine("Happy Birthday!");
                    break;
                case Holidays.Christmas:
                    Console.WriteLine("Merry Christmas!");
                    break;
                case Holidays.NewYear:
                    Console.WriteLine("Happy New Year!");
                    break;
                default:
                    Console.WriteLine("Holiday is not defined.");
                    break;
            }
        }

        //4
        public void NumberTypeForeach(int[] numbers)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }

            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        }

        //5
        public void NumberTypeFor(int[] numbers)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
                else
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        }

        //6
        public void CountyAndCapital(Dictionary<string, string> Capitals)
        {
            foreach (var country in Capitals)
            {
                Console.WriteLine($"Country is {country.Key}, which capital is {country.Value}");
            }
        }
    }
}
