using System;
using System.Collections.Generic;
using System.Linq;

namespace QALight_Task_6
{
    class Program
    {

        static void Main(string[] args)
        {
            //Task 1
            List<int> anyType = new List<int> {1, 2, 3, 4, 5};
            GetList(anyType);
            GetList(null);


            //Task 2
            List<Car> cars = new List<Car>
        {
            new Car { YearOfManufacture = 1997, NameOfCar = "BMW"},
            new Car { YearOfManufacture = 1989, NameOfCar = "Audi"},
            new Car { YearOfManufacture = 2006, NameOfCar = "Toyota"},
            new Car { YearOfManufacture = 2023, NameOfCar = "Ford" },
            new Car { YearOfManufacture = 2000, NameOfCar = "Tavria"},
        };
            List<Car> oldCars = cars.Where(car => car.YearOfManufacture <= 2000).ToList();
            List<Car> newCars = cars.Where(car => car.YearOfManufacture > 2000).ToList();
            List<string> oldCarNames = cars.Where(car => car.YearOfManufacture <= 2000).Select(car => car.NameOfCar).ToList();

            Console.WriteLine("\nOld cars` list:");
            foreach (var car in oldCars)
            {
                Console.WriteLine($"{car.YearOfManufacture} was manufactured in {car.NameOfCar}");
            }

            Console.WriteLine("\nNew cars` list:");
            foreach (var car in newCars)
            {
                Console.WriteLine($"{car.YearOfManufacture} was manufactured in {car.NameOfCar}");
            }

            Console.WriteLine("\nOld car names` list:");
            foreach (var name in oldCarNames)
            {
                Console.WriteLine(name);
            }

        }


        //Task 1
        public static void GetList(List <int> anyType)
        {
            try
            {
                Console.WriteLine($"5th list element is {anyType[5]}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("There is a null reference exception.");
            }
            catch (IndexOutOfRangeException) 
            {
                Console.WriteLine("There is an index out of range exception.");
            }
        }
    }
}
