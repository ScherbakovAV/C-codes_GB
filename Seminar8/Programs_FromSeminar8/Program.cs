// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine($"___Задача 53: Программа, меняющая местами первую и последнюю строку массива___\n");

int[,] arr1 = GetArrayInt();
System.Console.WriteLine($"Ваш массив №1:\n");
PrintArray(arr1);

int[,] arrTransposition = TranspositionArray(arr1);
System.Console.WriteLine($"Массив №1, где заменены первая и последняя строки:\n");
PrintArray(arrTransposition);

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


// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

Console.WriteLine($"___Задача 57: Частотный словарь элементов двумерного массива___\n");

int[,] arr3 = GetArrayInt();
Console.WriteLine($"Ваш массив №3:\n");
PrintArray(arr3);

Console.WriteLine();

MeetsCount(arr3);
Console.WriteLine($"\nМой метод::\n");
MeetsCountMy(arr3);

Console.WriteLine();

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Console.WriteLine($"___Задача 59: ___\n");

// int[,] arr4 = GetArrayInt();
// Console.WriteLine($"Ваш массив №4:\n");
// PrintArray(arr4);

// Console.WriteLine();


// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника


int[,] GetArrayInt()
{
    var rand = new Random();

    int[,] array = new int[rand.Next(1, 10), rand.Next(1, 10)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }

    return array;
}

void PrintArray(int[,] array)
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

int[,] TranspositionArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var temp = array[array.GetLength(0) - 1, i];

        array[array.GetLength(0) - 1, i] = array[0, i];

        array[0, i] = temp;
    }

    return array;
}

int[,] TurnArrayAndPrint(int[,] array)
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

void MeetsCount(int[,] array)
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

void MeetsCountMy(int[,] array)
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

// int[] RemoveInArray(int[,] array) // 
// {
//     int min = array[0,0];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             id
//         }   
//     }
// }

// int[,] GetArray()
// {

//     int[,] array = new int[new Random().Next(3, 6), new Random().Next(3, 6)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             array[i, j] = new Random().Next(10, 100);
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine();
//     return array;
// }

//  int [,] TPArray(int [,] Array)
//  {
//      for (int i = 0; i < Array.GetLength(1); i++)
//     {
//         var temp = Array [Array.GetLength(0)-1,i];

//         Array [Array.GetLength(0)-1,i] = Array [0,i];
//         Array [0,i] = temp;    
//     }   
//     return Array;
//   }    
//   void PrintArray(int [,] array)
//   {
//      for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//   }
// PrintArray(TPArray(GetArray()));


// зал по-иоему 4 
// public static int[,] SlovArr(int [,] MyArr)
//     {
//         int rows = MyArr.GetLength(0), cols = MyArr.GetLength(1);
//         int[,] slovar = new int[2, rows*cols];
//         int count = 0;   //количество разных цифр в массиве
//         slovar[0,0] =MyArr[0,0];
//         for ( int i = 0; i < rows; i++ )
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 for (int k = 0; k < rows*cols; k++)
//                 {
//                     if  (slovar[0,k] == MyArr[i,j])
//                     {
//                         slovar [1, k] ++;
//                         break;
//                     } 
//                     else 
//                     {
//                         count++;
//                         slovar[0, count] = MyArr[i,j];
//                         slovar[1, count] = 1;
//                     }
//                 }
//             }
//         }

//         return slovar;
//     }


/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */
// ____________________________________________________________________
// int[,] CreateRandomTwoDimensionalArray()
// {
//     Random random = new Random();
//     int rows = random.Next(3, 5);
//     int columns = random.Next(3, 5);
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(0, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }

// int[,] SwapArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//             var temp = arr[arr.GetLength(0) - 1, i];
//             arr [arr.GetLength(0) - 1, i] = arr[0, i];
//             arr[0, i] = temp;
//         }
//     return arr;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] array = SwapArray(CreateRandomTwoDimensionalArray());
// PrintArray(array);


// /* Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя. */
// int[,] CreateRandomTwoDimensionalArray()
// {
//     Random random = new Random();
//     int rows = random.Next(5, 6);
//     int columns = random.Next(5, 6);
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(0, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }

// int[,] SwapArray(int[,] arr)
// {
//     int row = arr.GetLength(0);
//     int columns = arr.GetLength(1);
//     int[,] arrNew = new int[row, columns];
//     if (row != columns)
//     {
//         Console.WriteLine("Ошибка");
//         return new int[1,1];
//     }
//     else
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 arrNew[j, i] = arr[i, j];
//             }
//         }
//         return arrNew;
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] array = SwapArray(CreateRandomTwoDimensionalArray());
// PrintArray(array);

// Метод Наташи

// void Dictionary()
// {
//     System.Console.WriteLine("row:");
//     int row = Convert.ToInt32(Console.ReadLine()!);
//     System.Console.WriteLine("columns:");
//     int columns = Convert.ToInt32(Console.ReadLine()!);

//     System.Console.WriteLine("min");
//     int min = Convert.ToInt32(Console.ReadLine()!);
//     System.Console.WriteLine("max");
//     int max = Convert.ToInt32(Console.ReadLine()!);
//     System.Console.WriteLine();
//     int[,] array = new int[row, columns];
//    Console.WriteLine($"\n массив со случайными элементами от {min} до {max - 1}:\n");
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j]=new Random().Next(min, max+1);
//             System.Console.Write($"{array[i,j]}   ");
//         }
//         System.Console.WriteLine();
//     }

//     int[]dictionary = new int[max+1];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             dictionary[array[i,j]]+=1;
//         }
//     }

//     for (int i = 0; i < dictionary.Length; i++)
//     {if (dictionary[i]>0)
//         System.Console.WriteLine($"{i} встречается {dictionary[i]} раз(а)");
//     }
// }
// Dictionary();