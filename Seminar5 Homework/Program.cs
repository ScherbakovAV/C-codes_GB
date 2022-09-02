using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nHello!\nOn first, enter arrays length\t");
            int lenghtArrays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            // Напишите программу, которая покажет количество чётных чисел в массиве.
            // [345, 897, 568, 234] -> 2

            Console.WriteLine($"_____Task №34_____\n");
            
            Console.WriteLine($"Numbers of even elements in this array is {CountEvenElements(GetArrayThreeDigit(lenghtArrays))}\n");
            // end

            // Задача 36: Задайте одномерный массив, заполненный случайными числами.
            // Найдите сумму элементов, стоящих на нечётных позициях.
            // [3, 7, 23, 12] -> 19
            // [-4, -6, 89, 6] -> 0

            Console.WriteLine($"_____Task №36_____\n");

            Console.WriteLine($"Sum of elements on odd index of this array is {SumOfElementsInOddPositions(GetArray(lenghtArrays))}\n");
            // end

            // Задача 37: Найдите произведение пар чисел в одномерном массиве.
            // Парой считаем первый и последний элемент, второй и предпоследний и т.д.
            // Результат запишите в новом массиве.
            // [1 2 3 4 5] -> 5 8 3
            // [6 7 3 6] -> 36 21

            Console.WriteLine($"_____Task №37_____\n");
            
            Console.WriteLine($"Product of pairs of numbers in this array is new array:\n{(MultOfPairs(GetArray(lenghtArrays)))}\n");
            // end
                    
            // Задача 38: Задайте массив вещественных чисел.
            // Найдите разницу между максимальным и минимальным элементов массива.
            // [3 7 22 2 78] -> 76
            
            Console.WriteLine($"_____Task №38_____\n");
            
            Console.WriteLine($"Difference between min and max numbers of array is {(DiffBetweenMaxMin(GetArray(lenghtArrays)))}\n");
            // end
        }

        static int[] GetArray(int sizeArray) // For task 36, 37, 38
        {
            int[] array = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(-100, 100);

            Console.WriteLine($"Your random array is:\n{String.Join(", ", array)}");

            return array;
        }

        static int[] GetArrayThreeDigit(int sizeArray) // For task 34
        {
            int[] array = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(100, 1000);

            Console.WriteLine($"Your random array with a three-digit is:\n{String.Join(", ", array)}");

            return array;
        }

        static int CountEvenElements(int[] array) // For task 34
        {
            int countNumEven = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) countNumEven++;
            }

            return countNumEven;
        }

        static int SumOfElementsInOddPositions(int[] array) // For task 36
        {
            int sumOddPos = 0;

            for (int i = 1; i < array.Length; i += 2) sumOddPos += array[i];

            return sumOddPos;
        }

        static string MultOfPairs(int[] array) // For task 37
        {
            int[] arrayMult = new int[(array.Length + 1) / 2];

            if (array.Length % 2 == 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    arrayMult[i] = array[i] * array[array.Length - 1 - i];
                }
            }

            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    arrayMult[i] = array[i] * array[array.Length - 1 - i];
                }

                arrayMult[array.Length / 2] = array[array.Length / 2];                                
            }

            string multArray = String.Join(", ", arrayMult);

            return multArray;
        }

        static double DiffBetweenMaxMin(int[] array) // For task 38
        {
            double minElement = array[0];
            double maxElement = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElement) minElement = array[i];
                if (array[i] > maxElement) maxElement = array[i];
            }

            Console.WriteLine($"Min element of array is {minElement}\nMax element of array is {maxElement}");

            return maxElement - minElement;
        }
    }
}