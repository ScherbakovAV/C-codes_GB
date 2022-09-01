// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] EnterRandomArray(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1001);
    }

    Console.WriteLine($"Your array is\n{String.Join(", ", array)}");

    return array;
}

void CounterOfElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }

    Console.WriteLine($"Count of elements from 10 to 99 in this array is... {count}");        
}

CounterOfElements(EnterRandomArray(20));

