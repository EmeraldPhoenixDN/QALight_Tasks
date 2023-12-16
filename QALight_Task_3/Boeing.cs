using System;


namespace QALight_Task_3
{
    public class Boeing : Plane
    {
        public Boeing(string typeOfPlain, int maxSpeed, int maxHeight, int yearOfIssue): base (typeOfPlain, maxSpeed, maxHeight, yearOfIssue)
        {
            TypeOfPlain = typeOfPlain;
            MaxSpeed = maxSpeed;
            MaxHeight = maxHeight;
            yearOfIssue = _yearOfIssue;
        }

        public override void ShowPlaneInfo()
        {
            Console.WriteLine($"Plane type is {TypeOfPlain}, max speed is {MaxSpeed}, max height is {MaxHeight}, year of issue is {_yearOfIssue}.");
        }
    }
}
