using System;

namespace QALight_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 3
            Plane airbus = new Airbus("Airbus", 1000, 5000, 2005);
            Plane boeing = new Boeing("Boeing", 1200, 4500, 2007);
            airbus.ShowPlaneInfo();
            boeing.ShowPlaneInfo();
            var yearOfIssue = airbus.GetYearOfIssue();
            Console.WriteLine("Airbus year of issue from GetYearOfIssue: " + yearOfIssue);
            yearOfIssue = boeing.GetYearOfIssue();
            Console.WriteLine("Boeing year of issue from GetYearOfIssue: " + yearOfIssue);

            //Part 5
            Helicopter apache = new Apache("Apache", 500, 2000, 2001);
            Helicopter atlas = new Atlas("Atlas", 700, 2500, 2009);
            apache.ShowHelicopterInfo();
            atlas.ShowHelicopterInfo();
            yearOfIssue = apache.GetYearOfIssue();
            Console.WriteLine("Apache year of issue from GetYearOfIssue: " + yearOfIssue);
            yearOfIssue = atlas.GetYearOfIssue();
            Console.WriteLine("Atlas year of issue from GetYearOfIssue: " + yearOfIssue);

            //Part 9
            Hangar.AddFlyingTransport(airbus);
            Hangar.AddFlyingTransport(boeing);
            Hangar.AddFlyingTransport(apache);
            Hangar.AddFlyingTransport(atlas);

            //Part 10
            Console.WriteLine($"Planes count: {Plane.PlaneCount}");
            Console.WriteLine($"Helicopter count: {Helicopter.HelicopterCount}");
        }
    }
}
