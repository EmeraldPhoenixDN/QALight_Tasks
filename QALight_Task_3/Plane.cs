

namespace QALight_Task_3
{
    public abstract class Plane : IFlyable
    {
        //Part 1
        public string TypeOfPlain { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxHeight { get; set; }
        protected int _yearOfIssue { get; set; }
        public static int PlaneCount { get; set; }

        public Plane (string typeOfPlain, int maxSpeed, int maxHeight, int yearOfIssue) {
            TypeOfPlain = typeOfPlain;
            MaxSpeed = maxSpeed;
            MaxHeight = maxHeight;
           _yearOfIssue = yearOfIssue;
        }

        public int GetYearOfIssue()
        {
            return _yearOfIssue;
        }

        public abstract void ShowPlaneInfo();

        public void RegisterFlyingTransport()
        {
            PlaneCount++;
         
        }
    }
}
