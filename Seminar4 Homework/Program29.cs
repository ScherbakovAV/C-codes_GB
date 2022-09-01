// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение.
// Надо заполнить массив рандоными данными от минимального до максимального значение.
// И важное уточнениее , делать все в методе который возвращает массив.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray()
{
    Console.Write("Enter quantity of array...");
    int arraySize = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    int[] arr = new int[arraySize];

    Console.Write("Enter minimum value of array...");
    int minNum = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter maximum value of array...");
    int maxNum = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= arraySize - 1; i++)
    {
        if (minNum <= maxNum) arr[i] = new Random().Next(minNum, maxNum + 1);
        else arr[i] = new Random().Next(maxNum, minNum + 1);
    }

    return arr;
}

void SortAndPrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[min] > arr[j]) min = j;
        }

        int temp = arr[min];
        arr[min] = arr[i];
        arr[i] = temp;

        if (i == arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
    }
}

int[] array = RandomArray();
SortAndPrintArray(array);