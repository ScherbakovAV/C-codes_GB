// написать программу, которая выдаёт случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int MaxNumber() // это статический метод
        {
            int number1 = new Random().Next(10, 1000);
            int max = 0;
            int iterator = number1;

            while(iterator != 0)
            {
                int number2 = iterator % 10;

                if (number2 > max) max = number2;

                iterator /= 10;
                // iterator = iterator / 10
            }

        }

        static int MaxNumber2() // это статический метод
        {
            int number = new Random().Next(10, 1000);
            int number1 = number % 10;
            int number2 = number % 10;

            int max = number1;

            if (number1 < number2)
            {
                max = number2;
            }
            System.Console.WriteLine("null");

        }
    }
}
