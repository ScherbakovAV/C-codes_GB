Console.Clear();

// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine($"___Задача 53: Программа, меняющая местами первую и последнюю строку массива___\n");

int[,] arr1 = GetArrayInt();
System.Console.WriteLine($"Ваш массив №1:\n");
PrintArray(arr1);

int[,] arrTransposition = TranspositionArray(arr1);
System.Console.WriteLine($"\nМассив №1, где заменены первая и последняя строки:\n");
PrintArray(arrTransposition);

Console.WriteLine($"\nНажмите любую клавишу для продолжения...\n");
Console.ReadKey();

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine($"___Задача 55: Программа, меняющая строки на столбцы___\n");

int[,] arr2 = GetArrayInt();
Console.WriteLine($"Ваш массив №2:\n");
PrintArray(arr2);

int[,] turnArr = TurnArrayAndPrint(arr2);
if (turnArr != null)
{
    Console.WriteLine($"Массив №2, где заменены строки на столбцы:\n");
    PrintArray(turnArr);
}

Console.WriteLine($"\nНажмите любую клавишу для продолжения...\n");
Console.ReadKey();

// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

Console.WriteLine($"___Задача 57: Частотный словарь элементов двумерного массива___\n");

int[,] arr3 = GetArrayInt();
Console.WriteLine($"Ваш массив №3:\n");
PrintArray(arr3);

Console.WriteLine();

Console.WriteLine($"\nРешение с семинара:\n");
MeetsCount(arr3);
Console.WriteLine($"\nМоё решение:\n");
MeetsCountMy(arr3);
Console.WriteLine($"\nРешение комнаты 4:\n");
SlovArr(arr3);
Console.WriteLine($"\nРешение Наташи:\n");
Dictionary();

Console.WriteLine($"\nНажмите любую клавишу для продолжения...\n");
Console.ReadKey();

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.WriteLine($"___Задача 59: удаление строки и столбца на пересечении с минимальным элементом массива___\n");

int[,] arr4 = GetArrayInt();
Console.WriteLine($"Ваш массив №4:\n");
PrintArray(arr4);

//FindMinAndRemoveInArray(arr4);

Console.WriteLine($"\nТут должно быть решение по удалению строки и столбца массива\n");
Console.WriteLine($"\nНажмите любую клавишу для продолжения...\n");
Console.ReadKey();

// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника.

// Решение Камянецкого

Console.Clear();

int row = 30;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

Console.ReadLine();
FillTriangle();
PrintTriangle();
Console.WriteLine();
Magic();

Console.WriteLine($"\nНажмите любую клавишу для выхода...\n");
Console.ReadKey();

//----------------М-Е-Т-О-Д-Ы----------------   

int[,] GetArrayInt() // 53, 55 ,57, 59
{
    var rand = new Random();

    int[,] array = new int[rand.Next(1, 10), rand.Next(1, 10)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array) // 53, 55 ,57, 59
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] TranspositionArray(int[,] array) // 53
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var temp = array[array.GetLength(0) - 1, i];

        array[array.GetLength(0) - 1, i] = array[0, i];

        array[0, i] = temp;
    }

    return array;
}

int[,] TurnArrayAndPrint(int[,] array) // 55
{
    int length = array.GetLength(0);

    int[,] arrTurn = new int[length, length];

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arrTurn[i, j] = array[j, i];
            }
        }
        return arrTurn;
    }
    else
    {
        Console.WriteLine("Данный массив нельзя перевернуть!");
        return null!;
    }
}

void MeetsCount(int[,] array) // 57
{
    int[] mass = new int[100];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mass[array[i, j]] += 1;
        }
    }

    for (int k = 0; k < mass.Length; k++)
    {
        if (mass[k] != 0) Console.WriteLine($"Элемент {k} повторяется {mass[k]} раз");
    }
}

void MeetsCountMy(int[,] array) // 57 (моё решение)
{
    int count = 0;

    int[] arrCompare = new int[200];

    for (int k = 0; k < 199; k++)
    {
        arrCompare[k] = k - 99;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (arrCompare[k] == array[i, j]) count++;

            }
        }
        if (count != 0)
        {
            Console.WriteLine($"Элемент со значением {arrCompare[k]} встречается в массиве {count} раз");
            count = 0;
        }
    }
}

// Метод Наташи

void Dictionary() // 57 (решение Наташи)
{
    System.Console.WriteLine("row:");
    int row = Convert.ToInt32(Console.ReadLine()!);
    System.Console.WriteLine("columns:");
    int columns = Convert.ToInt32(Console.ReadLine()!);

    System.Console.WriteLine("min");
    int min = Convert.ToInt32(Console.ReadLine()!);
    System.Console.WriteLine("max");
    int max = Convert.ToInt32(Console.ReadLine()!);
    System.Console.WriteLine();
    int[,] array = new int[row, columns];
    Console.WriteLine($"\n массив со случайными элементами от {min} до {max - 1}:\n");
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            System.Console.Write($"{array[i, j]}   ");
        }
        System.Console.WriteLine();
    }

    int[] dictionary = new int[max + 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dictionary[array[i, j]] += 1;
        }
    }

    for (int i = 0; i < dictionary.Length; i++)
    {
        if (dictionary[i] > 0)
            System.Console.WriteLine($"{i} встречается {dictionary[i]} раз(а)");
    }
}

int[,] SlovArr(int[,] MyArr) // 57 (зал 4)
{
    int rows = MyArr.GetLength(0), cols = MyArr.GetLength(1);
    int[,] slovar = new int[2, rows * cols];
    int count = 0;   //количество разных цифр в массиве
    slovar[0, 0] = MyArr[0, 0];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < rows * cols; k++)
            {
                if (slovar[0, k] == MyArr[i, j])
                {
                    slovar[1, k]++;
                    break;
                }
                else
                {
                    count++;
                    slovar[0, count] = MyArr[i, j];
                    slovar[1, count] = 1;
                    count = 0;
                }
            }
        }
    }

    return slovar;
}

/* int FindMinInArray(int[,] array) // 59
{
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= min)
            {
                min = array[i, j];
            }
        }
    }

    Console.WriteLine($"\nМинимальный элемент массива равен {min}");

    return min;
} */

/* int EntryOfUnitInArray(int[,] array, int num) // 59
{
    int entry = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                entry++;
            }
        }
    }

    Console.WriteLine($"Этот элемент встречается {entry} раз\n");

    return entry;
} */

/* int[,] DeleteRowsColumnsInArray(int[,] array, int number, int entry = 1) // 59
{
    int[,] arrReduced = new int[array.GetLength(0) - entry, array.GetLength(1) - entry];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {

            }
        }
    }
    return arrReduced;
} */

void FillTriangle() // 61
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle() // 61
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.WriteLine($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic() // 61
{
    int col = cellWidth * row;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            // if (triangle[i, j] % 2 != 0) Console.WriteLine("*");
            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);

        Console.WriteLine();
    }
}





