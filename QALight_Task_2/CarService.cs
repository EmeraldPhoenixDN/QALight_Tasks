using System;


namespace QALight_Task_2
{
    class CarService
    {
        public void MakeService(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.Type} has arrived.");
        }
    }
}
