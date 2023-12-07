using System;

namespace QALight_Task_1
{
    public class Student
    {
        string _studentName = "Heorhii";
        int _studentAge = 26;
        int _studentScore = 100;

        //Classes and methods, task 1
        public void studentDetails()
        {
            Console.WriteLine($"Part 3, Task 1. \n Student`s name: {_studentName}, Student`s age: {_studentAge}, Student`s Score: {_studentScore}\n");
        }

        //Classes and methods, task 3
        public void studentHello(string studentName)
        {
            Console.WriteLine($"Part 3, Task 3. \n Hi, student {studentName}\n");
        }

    }
}
