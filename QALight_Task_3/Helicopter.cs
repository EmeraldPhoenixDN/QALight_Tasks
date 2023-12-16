namespace QALight_Task_3
{
    public abstract class Helicopter : IFlyable
    {
        //Part 1
        public string TypeOfHelicopter { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxHeight { get; set; }
        protected int _yearOfIssue { get; set; }
        public static int HelicopterCount { get; set; }

        public Helicopter (string typeOfHelicopter, int maxSpeed, int maxHeight, int yearOfIssue) {
            TypeOfHelicopter = typeOfHelicopter;
            MaxSpeed = maxSpeed;
            MaxHeight = maxHeight;
           _yearOfIssue = yearOfIssue;
        }

        public int GetYearOfIssue()
        {
            return _yearOfIssue;
        }

        public abstract void ShowHelicopterInfo();

        public void RegisterFlyingTransport()
        {
            HelicopterCount++;
        }

    }
}
