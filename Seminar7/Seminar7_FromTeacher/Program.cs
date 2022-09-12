//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine()!);

int[,] array = GetArraySum(rows, columns);
PrintArray(array);

int[,] GetArraySum(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine()!);

 array = GetArrayDouble(rows, columns,0,10);
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));



int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}


Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine()!);

 array = GetArrayDouble(rows, columns,0,10);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {GetSumDiag(array)}");


int GetSumDiag(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}



//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
 columns = int.Parse(Console.ReadLine()!);

array = GetArrayDouble(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}




//метод возвращающий индекс опорного элемента
int Partition(int[] array, int minIndex, int maxIndex)
{
    var pivot = minIndex - 1;//-1
    for (var i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
           
            var tmp = array[pivot];
            array[pivot] = array[i];
            array[i] = tmp;
        }
    }

    pivot++;

    var temp = array[pivot];
    array[pivot] = array[maxIndex];
    array[maxIndex] = temp;
    return pivot;
}

//быстрая сортировка
int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    var pivotIndex = Partition(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

int[] GetArray(int size = 12, int minValue = -100, int maxValue = 100)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


var arr = GetArray();

Console.WriteLine("Mассив: {0}", string.Join(", ", arr));
var arraySort= QuickSort(arr,0, arr.Length - 1);
Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", arraySort));

Console.ReadLine();