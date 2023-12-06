using System;

namespace QALight_Task_1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Variables and data types, task 1
            string studentName = "Heorhii";
            int studentAge = 26;
            int studentScore = 100;
            Console.WriteLine($"Part 1, task 1: Student name: {studentName}, student age: {studentAge}, student score: {studentScore}\n");

            //Variables and data types, task 2
            Console.WriteLine("Part 1, task 2. 1: 1 + 2 = " + arithmeticOperations("1", "2") + "\n");

            //Arithmetic operations, task 1
            arithmeticOperations(10, 5);

            //Arithmetic operations, task 2
            arithmeticAverage(4, 7, 11);
            
            //Classes and methods, task 1
            Student student1 = new Student();
            student1.studentDetails();

            //Classes and methods, task 2
            Calculator calculator1 = new Calculator();
            calculator1.arithmeticSum();
            calculator1.arithmeticSub();
            calculator1.arithmeticMul();
            calculator1.arithmeticDiv();

            //Classes and methods, task 3
            Student student2 = new Student();
            student2.studentHello("Heorhii");
            Student student3 = new Student();
            student3.studentHello("Illia");

            //Classes and methods, task 4
            Console.WriteLine("Part 3, task 4. 1: 1 + 2 = " + arithmeticSumOverloading(1, 2) + "\n");
            Console.WriteLine("Part 3, task 4. 1: 1 + 2 = " + arithmeticSumOverloading("1", "2") + "\n");

        }

        //Variables and data types, task 2
        static private int arithmeticOperations(string firstValue, string secondValue)
        {
            int Sum = Convert.ToInt32(firstValue) + Convert.ToInt32(secondValue);
            return Sum;
        }

        //Arithmetic operations, task 1

        static private void arithmeticOperations(double firstValue, double secondValue) 
        {
            double arithmeticSum = firstValue + secondValue;
            double arithmeticSub = firstValue - secondValue;
            double arithmeticMul = firstValue * secondValue;
            double arithmeticDiv = firstValue / secondValue;
            Console.WriteLine($"Part 2, task 1: First value = {firstValue}, Second value = {secondValue}.\n Arithmetic sum = {arithmeticSum}, arithmetic substraction = {arithmeticSub}, arithmetic multiplication = {arithmeticMul}, arithmetic division = {arithmeticDiv}\n");
        }

        //Arithmetic operations, task 2
        static private void arithmeticAverage(int firstValue, int secondValue, int thirdValue)
        {
            int arithmeticAverageResult = (firstValue + secondValue + thirdValue) / 3;
            Console.WriteLine($"Part 2, task 2: First value = {firstValue}, Second value = {secondValue}, Third value = {thirdValue}.\n Arithmetic average = {arithmeticAverageResult} \n");
        }

        //Classes and methods, task 4
        static private int arithmeticSumOverloading(int firstValue, int secondValue)
        {
            int Sum = Convert.ToInt32(firstValue) + Convert.ToInt32(secondValue);
            return Sum;
        }

        //Classes and methods, task 4
        static private int arithmeticSumOverloading(string firstValue, string secondValue)
        {
            int Sum = Convert.ToInt32(firstValue) + Convert.ToInt32(secondValue);
            return Sum;
        }


    }
}
