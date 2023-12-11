using System;
using System.Linq;

namespace QALight_Task_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Task 1 beginning
            string hello = "Hello, How Are YoU?";
            Console.WriteLine(hello);

            var helloSplit = hello.Split(',').Last();
            Console.WriteLine(helloSplit);

            var helloWithoutSpaces = helloSplit.Trim();
            Console.WriteLine(helloWithoutSpaces);

            var helloToLower = helloWithoutSpaces.ToLower();
            Console.WriteLine(helloToLower);

            var helloSubstring = hello.Substring(0,5);
            Console.WriteLine(helloSubstring);
            //Task 1 ending

            //Task 2
            var carService = new CarService();
            var car = new Car {Type = "Car" };
            var bike = new Bike { Type = "Bike" };
            carService.MakeService(car);
            carService.MakeService(bike);
        }
    }
}
