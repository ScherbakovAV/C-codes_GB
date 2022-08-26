using System;

namespace SeminarHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(1, 100000);
            //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

            ViewSecondNumber(num);

            //

            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            System.Console.Write("Введите число: ");
            num = int.Parse(Console.ReadLine());

            System.Console.Write("Введите индекс: ");
            int numIndex = int.Parse(Console.ReadLine());

            ViewaThirdNumber1(num, numIndex);
            //

            //Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

            System.Console.Write("Введите день недели: ");
            int dayWeek = int.Parse(Console.ReadLine());

            DayOffWeek(dayWeek);

            //
        }

        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        static void ViewSecondNumber(int num)
        {
            if (num > 99 && num < 1000)
            {
                int secondNumber = num / 10 % 10;

                Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
            }
            else
                Console.WriteLine($"Число {num} не трёхзначное");
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        static void ViewaThirdNumber1(int num, int index)
        {
            if (num > 99)
            {
                int length = (int)Math.Log10(num) + 1;
                int numberPow = (int)Math.Pow(10, length - index);
                int result = num / numberPow % 10;

                Console.WriteLine($"{index} цифра в числе {num} -> {result}");
            }
            else
                Console.WriteLine($"У числа нет трёх цифр");
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //То что дала GeekBrains
        static void ViewaThirdNumber2(int num, int index = 3)
        {
            Console.Clear();
           
            if (num < 100)
            {
                Console.WriteLine($"Третьей цифры нет");
                return;
            }
            int thirdNumber = (num / 100) % 10;
            Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");
        }

        //Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
        static void DayOffWeek(int dayWeek)
        {
            switch (dayWeek)
            {
                case 1:
                    Console.WriteLine("Понедельник- НЕТ");
                    break;
                case 2:
                    Console.WriteLine("Вторник- НЕТ");
                    break;
                case 3:
                    Console.WriteLine("Среда- НЕТ");
                    break;
                case 4:
                    Console.WriteLine("Четверг- НЕТ");
                    break;
                case 5:
                    Console.WriteLine("Пятница- Да");
                    break;
                case 6:
                    Console.WriteLine("Суббота- Нет");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье- Нет");
                    break;
                default:
                    Console.WriteLine("Некорректный номер дня недели");
                    break;
            }
        }
    }
}