// Задаём рандомный массив из n элементов, в котором необходимо найти заданное число

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // вместо "0", чтобы в случае ненахождения искомого числа на экран выводилось "-1"

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // массив из 10 элементов, по умолчанию заполненный нулями
// чтобы изменить умолчание, используем метод (вверху)

FillArray(array); // заполнение массива
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);