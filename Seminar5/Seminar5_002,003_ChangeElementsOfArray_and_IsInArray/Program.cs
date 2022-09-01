// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] EnterRandomArray()
{
    Console.Write("Enter length of array...\t");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

void ChangeElements(int[] array)
{
    Console.WriteLine($"You array:       {String.Join(", ", array)}");
    
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = -1 * array[j];
    }

    Console.WriteLine($"You revert array: {String.Join(", ", array)}");
}


bool IsInArray(int[] array)
{
    Console.Write("Enter a number for find in array...\t");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You array: {String.Join(", ", array)}");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }

    return false;
}

ChangeElements(EnterRandomArray());

Console.WriteLine(IsInArray(EnterRandomArray()));

