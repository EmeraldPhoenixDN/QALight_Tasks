using System;

namespace QALight_Task_5
{
    public class Human
    {
        public string Name { get; set; }

    

        public void GetName(Human human)
        {
            {
                try
                {
                    Console.WriteLine($"Human name is {human.Name}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Human name cannot be null!");
                }
            }
        }
    }
}
