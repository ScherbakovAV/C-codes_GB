using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();
        //Напишите программу, которая принимает на вход три числа и проверяет, 
        //может ли существовать треугольник с сторонами такой длины.
        Console.WriteLine($"---Проверка возможности существования треугольника с заданными сторонами---\n");

        Console.Write("Введите стороны треугольника через пробел:\t");

        string[] st = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])))
        {
            Console.WriteLine("\nТакой треугольник существует");
        }
        else
        {
            Console.WriteLine("\nТакой треугольник не может существовать");
        }

        bool IsTriangle(int a, int b, int c)
        {
            return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
        }


        //Напишите программу, 
        //которая будет преобразовывать десятичное число в двоичное.

        Console.WriteLine($"\n---Преобразование числа из двоичной системы счисления в двоичную---\n");

        Console.Write("Введите десятичное число:\t");

        int decNum = Convert.ToInt32(Console.ReadLine());

        string res1 = Convert.ToString(decNum, 2);
        Console.WriteLine($"\nПо методу 1: {decNum} -> {res1}\n");

        string res2 = String.Join("", DecToNumBool(decNum));
        Console.Write($"По методу 2: {decNum} -> ");
        Console.WriteLine(res2.Replace("True", "1").Replace("False", "0"));

        string res3 = DecToNumUniversal(decNum, 2);
        Console.WriteLine($"\nПо методу 3: {decNum} -> {res3}\n");

        //Универсальный математический для перевода из 10 в двоичную

        bool[] DecToNumBool(int num) // для метода 2
        {
            int result = 0;
            bool[] arr = new bool[32];
            int i;
            for (i = 0; num > 0; i++)
            {
                result = num % 2;
                num = num / 2;
                arr[arr.Length - 1 - i] = Convert.ToBoolean(result);
            }
            return arr;
        }

        //Универсальный математический для перевода из 10 в любую
        string DecToNumUniversal(int decNumber, int otherSystem = 2) // для метода 3
        {
            string res = String.Empty;
            string nums = "0123456789ABCDEF";
            int ost;

            while (decNumber > 0)
            {
                ost = decNumber / otherSystem;
                res = nums[decNumber - otherSystem * ost] + res;
                decNumber = ost;
            }
            return res;
        }

        // Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

        Console.WriteLine($"\n---Создание копии заданного массива с помощью поэлементного копирования---\n");

        int[] array = GetArray();
        Console.WriteLine($"\nЗаданный рандомный массив:\n[{String.Join(", ", array)}]\n");

        int[] copyArray = CopyArray(array);
        Console.WriteLine($"Копия этого массива:\n[{String.Join(", ", copyArray)}]\n");

        int[] CopyArray(int[] inArray)
        {
            int[] result = new int[inArray.Length];
            for (int i = 0; i < inArray.Length; i++)
            {
                result[i] = inArray[i];

            }
            return result;
        }

        int[] GetArray()
        {
            Console.Write("Введите размер массива:\t");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минимальное число массива:\t");
            int minValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное число массива:\t");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[] res = new int[size];

            for (int i = 0; i < size; i++)
            {
                res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
        }


        //Напишите программу, которая перевернёт одномерный массив 
        //(последний элемент будет на первом месте, а первый - на последнем и т.д.)

        Console.WriteLine($"\nПеревёрнутый массив по методу 1:\n[{String.Join(", ", ReversArray1(array))}]\n");

        Console.WriteLine($"\nПеревёрнутый массив по методу 2:\n[{String.Join(", ", ReversArray2(copyArray))}]\n");

        Array.Reverse(copyArray);

        Console.WriteLine($"\nПеревёрнутый массив по методу 3:\n[{String.Join(", ", copyArray)}]\n");


        int[] ReversArray1(int[] inArray) // этот метод изменяет входящий массив, насколько я понял
        {
            int[] outArray = new int[inArray.Length];
            for (int i = 0; i < inArray.Length; i++)
            {
                int numTemp = inArray[i];
                outArray[i] = inArray[inArray.Length - i - 1];
                inArray[inArray.Length - i - 1] = numTemp;
            }
            return outArray;
        }

        int[] ReversArray2(int[] inArray) // этот метод оставляет входящий массив без изменений
        {
            int[] result = new int[inArray.Length];
            for (int i = 0; i < inArray.Length; i++)
            {
                result[i] = inArray[inArray.Length - 1 - i];

            }
            return result;
        }

        //Три варианта вывода чисел Фибоначчисо сравнением времени выполнения

        Console.WriteLine($"\n---Вывод первых N чисел Фибоначчи---\n");

        double FibonacciBad(int n) // первый метод - через рекурсию напрямую
        {
            if ((n == 1) || (n == 2)) return 1;
            else return FibonacciBad(n - 1) + FibonacciBad(n - 2);
        }

        double FibonacciR(double[] f, int n) // второй метод - через рекурсию с проверками
        {
            if (n == 1 || n == 2)
            {
                return f[n - 1] = 1;
            }
            else
            {
                if (f[n - 2] != 0)
                {
                    if (f[n - 1] != 0)
                        return f[n - 1] = f[n - 2] + f[n - 3];
                    else
                        return f[n - 1] = FibonacciR(f, n - 1) + f[n - 3];
                }
                else
                    return f[n - 1] = FibonacciR(f, n - 1) + FibonacciR(f, n - 2);
            }
        }

        double FibonacciGood(int n)
        {

            double[] f = new double[n];
            return FibonacciR(f, n);
        }


        int countTests = 45;

        DateTime saveTime;

        Console.WriteLine($"Через цикл:\n"); // первый метод

        saveTime = DateTime.Now;
        int fibonacci1 = 1;
        int fibonacci2 = 1;
        Console.WriteLine($"F({1}) = {fibonacci2}");
        for (int i = 1; i < countTests; i++)
        {
            Console.WriteLine($"f({i + 1}) = {fibonacci2}");
            int temporary = fibonacci2;
            fibonacci2 += fibonacci1;
            fibonacci1 = temporary;
        }


        Console.WriteLine($"\nВремя нахождения первых {countTests} чисел Фибоначчи через цикл: {DateTime.Now - saveTime}");

        Console.WriteLine($"\nЧерез рекурсию с проверками:\n"); // второй метод
        saveTime = DateTime.Now;
        for (int i = 1; i <= countTests; i++)
        {
            Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
        }


        Console.WriteLine($"\nВремя нахождения первых {countTests} чисел Фибоначчи через рекурсию с проверками: : {DateTime.Now - saveTime}");

        Console.WriteLine($"\nЧерез рекурсию напрямую:\n"); // третий метод

        saveTime = DateTime.Now;

        for (int i = 1; i <= countTests; i++)
        {
            Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
        }

        Console.WriteLine($"\nВремя нахождения первых {countTests} чисел Фибоначчи через рекурсию напрямую: {DateTime.Now - saveTime}");
    }
}
