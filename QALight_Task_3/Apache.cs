using System;


namespace QALight_Task_3
{
    public class Apache : Helicopter
    {
        public Apache(string typeOfHelicopter, int maxSpeed, int maxHeight, int yearOfIssue) : base(typeOfHelicopter, maxSpeed, maxHeight, yearOfIssue)
        {
            TypeOfHelicopter = typeOfHelicopter;
            MaxSpeed = maxSpeed;
            MaxHeight = maxHeight;
            yearOfIssue = _yearOfIssue;
        }

        public override void ShowHelicopterInfo()
        {
            Console.WriteLine($"Helicopter type is {TypeOfHelicopter}, max speed is {MaxSpeed}, max height is {MaxHeight}, year of issue is {_yearOfIssue}.");  
        }
    }
}
