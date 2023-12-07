using System;


namespace QALight_Task_1
{
    class Calculator
    {
        double _firstValue = 11;
        double _secondValue = 3;

        public void arithmeticSum()
        {
            double arithmeticSum = _firstValue + _secondValue;
            Console.WriteLine($"Part 3, task 2: First value = {_firstValue}, Second value = {_secondValue}.\n Arithmetic sum = {arithmeticSum}\n");
        }

        public void arithmeticSub()
        {
            double arithmeticSub = _firstValue - _secondValue;
            Console.WriteLine($"Part 3, task 2: Arithmetic substraction = {arithmeticSub}\n");
        }

        public void arithmeticMul()
        {
            double arithmeticMul = _firstValue * _secondValue;
            Console.WriteLine($"Part 3, task 2: Arithmetic multiplication = {arithmeticMul}\n");
        }

        public void arithmeticDiv()
        {
            double arithmeticDiv = _firstValue / _secondValue;
            Console.WriteLine($"Part 3, task 2:  Arithmetic division = {arithmeticDiv}\n");
        }
    }
}
