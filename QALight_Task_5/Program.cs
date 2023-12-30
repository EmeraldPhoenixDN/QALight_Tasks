using System;

namespace QALight_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int IntVariable = 0;
            Console.WriteLine("All values < 10 using while loop:");
            while (IntVariable < 10)
                {
                Console.WriteLine(IntVariable++);
            }

            //Task 2
            int IntVariableTen = 10;
            while (IntVariableTen < 10)
            {
                Console.WriteLine(IntVariableTen++);
            }

            //Task 3
            int IntVariableDoWhile = 0;
            Console.WriteLine("All values < 10 using do-while loop:");
            do
            {
                Console.WriteLine(IntVariableDoWhile++);
            }
            while (IntVariableDoWhile < 10);

            //Task 4
            int IntVariableTenDoWhile = 10;
            Console.WriteLine($"All values < 10 using do-while loop with IntVariableTenDoWhile = {IntVariableTenDoWhile}:");
            do
            {
                Console.WriteLine(IntVariableTenDoWhile++);
            }
            while (IntVariableTenDoWhile < 10);

            //Task 5
            Human human = new Human();
            human.GetName(null);
        }
    }
}
