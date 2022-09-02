using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {   // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            // 14212 -> нет
            // 12821 -> да
            // 23432 -> да
            int numPalindrome = SetNumber("Palindrome");

            bool isPalindrome = IsPalindromeInt(numPalindrome);

            // bool isPalindrome = IsPalindromeString(numPalindrome.ToString());

            string str = isPalindrome ? "является палиндромом" : "не является палиндромом";

            System.Console.WriteLine($"число {numPalindrome} {str}");
            /*конец*/

            // Задача 21
            // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            // A (3,6,8); B (2,1,-7), -> 15.84
            // A (7,-5, 0); B (1,-1,9) -> 11.53
            int x1 = SetNumber("x1");
            int y1 = SetNumber("y2");
            int z1 = SetNumber("z3");
            int x2 = SetNumber("x2");
            int y2 = SetNumber("y2");
            int z2 = SetNumber("z2");

            double result = DistanceBetween3DPoints(x1, x2, y1, y2, z1, z2);
            System.Console.WriteLine($"result {result}");
            /*конец*/

            // Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            //3-> 1, 8, 27
            // 5-> 1, 8, 27, 64, 125
            int num = SetNumber("N");

            int[] arr = CubeTable(num);

            System.Console.WriteLine(String.Join(",", arr));
            /*конец*/



            //DistanceBetweenPoints(x1, x2, y1, y2);
            //ViewQuarterNumber();

            //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

            //     Console.Write("Введите X1: ");
            //     int x1 = int.Parse(Console.ReadLine());
            //     Console.Write("Введите Y1: ");
            //     int y1 = int.Parse(Console.ReadLine());
            //    Console.Write("Введите X2: ");
            //     int x2 = int.Parse(Console.ReadLine());
            //     Console.Write("Введите Y2: ");
            //     int y2 = int.Parse(Console.ReadLine());

            //     DistanceBetweenPoints(x1, x2, y1, y2);
            //

        }

        // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        public static bool IsPalindromeInt(int num) //12321
        {
            int temp = num; // temp = 12321
            int revert = 0; // revert = 0
            while (temp > 0)
            {
                revert = (revert * 10) + (temp % 10); // 1) revert = 0 + 1 = 1 (2) 10 + 2 = 12 (3) 120 + 3 = 123
                temp /= 10;                           // 1) temp = 1232        (2) 123         (3) 12
            }

            return revert == num;
        }

        public static bool IsPalindromeString(string str)
        {
            int size = str.Length;
            for (int i = 0; i <= size / 2; ++i)
            {
                if (str[i] != str[size - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        // конец
        //Задача 21 . Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

        static int SetNumber(string numberName)
        {
            Console.Write($"Enter number {numberName}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        static double DistanceBetween3DPoints(int x1, int x2, int y1, int y2, int z1, int z2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
        }
        // конец

        // Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

        static int[] CubeTable(int n)
        {
            int[] arr = new int[n];

            for (int i = 1; i <= n; i++)
            {
                arr[i - 1] = i * i * i;
            }

            return arr;
        }

        // конец




        //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
        static void DistanceBetweenPoints(int x1, int x2, int y1, int y2)
        {
            double distanceBetweenPoints = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine($"Distance Between Points={distanceBetweenPoints:f2}");
        }

        //Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
        static void SquaresTable(int number)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{i * i} ");
            }
        }

        //17. Напишите программу, которая принимает на вход координаты точки (X и Y),
        //причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
        static void ViewQuarterNumber()
        {
            Console.Write("Введите X: ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("1 четверть");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("2 четверть");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("3 четверть");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("4 четверть");
            }
        }


        //Задача 18: Напишите программу, которая по заданному номеру четверти, 
        //показывает диапазон возможных координат точек в этой четверти (x и y).
        static void ViewRangePossibleCoordinates()
        {
            //Напишите программу, которая по заданному номеру четверти, 
            //показывает диапазон возможных координат точек в этой четверти (x и y).
            Console.Clear();
            Console.Write("Введите номер четверти: ");
            int quarter = Convert.ToInt32(Console.ReadLine());

            switch (quarter)
            {
                case 1:
                    {
                        Console.WriteLine("x>0 y>0");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("x<0 y>0");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("x<0 y<0");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("x>0 y<0");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Введена неправильная четверть");
                        break;
                    }
            }
        }

    }


}