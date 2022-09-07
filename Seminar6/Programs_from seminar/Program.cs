// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] GetArray()
// {
//     int[] array = new int[];
// }

// void ReverseArray1(int[] array)
// {

// }

// void ReverseArray2(int[] array)
// {
    
// }

// void ReverseArray3(int[] array)
// {
    
// }

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// bool IsTriangle(int sideA, int sideB, int sideC)
// {
//     if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB) return true;
//     else return false;
// }

// Console.WriteLine("Enter a first side of triangle...");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter a second side of triangle...");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter a third side of triangle...");
// int C = Convert.ToInt32(Console.ReadLine());

// string triangleTrue = IsTriangle(A, B, C) ? "This triangle is exists" : "This triangle is NOT exists";

// System.Console.WriteLine(triangleTrue);


// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int[] DECtoBIN(int num)
// {
//     int[] result = new int[32];

//     for (int i = 0; num != 0; i++)
//     {
//         result[result.Length - 1 - i] = num % 2;
//         num = num / 2;
//     }

//     return result;
// }

// string DECtoBINforSTR(int num)
// {
//     string result = String.Empty;
    
//     for (int i = 0; num != 0; i++)
//     {
//         result = Convert.ToString(num % 2) + result;
//         num = num / 2;
//     }

//     return result;
// }

// Console.WriteLine("Enter a integer number...");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"This number is convert to binary from number:\n{String.Join("", DECtoBIN(number))}");

// Console.WriteLine($"This number is convert to binary from string:\n{DECtoBINforSTR(number)}");




/* Решение другой группы

System.Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

bool[] array = Num2(num);

System.Console.WriteLine(String.Join("", array));
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(Convert.ToInt32(array[i]));
}
bool[] Num2 (int num)
{

int result = 0;
bool[] arr = new bool[32];
int i;
for (i = 0; num > 0; i++)
{
    result = num%2;
    num = num/2;
    arr[arr.Length -1 -i] = Convert.ToBoolean(result);
}
return arr;
}
*/

// // Решение группы 3001 через рекурсию

// System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// PrintBinaryView(number);
// void PrintBinaryView(int decNumber)
// {
//     if (decNumber <= 0) return;

//     else
//     {
//         PrintBinaryView(decNumber / 2);
//         System.Console.Write(decNumber % 2);
//     }
// }




// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987

// int[] ArrayFibonacci()
// {
//     System.Console.WriteLine("Enter an amount of numbers of Fibonacci...");
//     int numFib = Convert.ToInt32(Console.ReadLine());

//     int[] arrayFib = new int[numFib];

//     arrayFib[0] = 0;
//     arrayFib[1] = 1;
//     arrayFib[2] = 1;

//     for (int i = 3; i < numFib; i++)
//     {
//         arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
//     }

//     return arrayFib;
// }

// System.Console.WriteLine(String.Join(", ", ArrayFibonacci()));


// Решение группы 3001

// int f1 = 0, f2 = 1, sum = 0, n = 15;

// Console.Write("0 1 ");

// for (int i = 2; i < n; i++)
// {
//     sum = f1 + f2;
//     Console.Write($"{sum} ");
//     f1 = f2;
//     f2 = sum;
// }


// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

// int[] GetArray(int sizeArray)
// {
//     int[] array = new int[sizeArray];

//     for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(1, 100);

//     Console.WriteLine($"Your random array is:\n{String.Join(", ", array)}");

//     return array;
// }

// int[] CopyofArray(int[] arr)
// {
//     int[] copyArr = new int[arr.Length];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         copyArr[i] = arr[i];  
//     }

//     return copyArr;
// }

// System.Console.WriteLine("Enter a size of array...");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Copy of this array is:\n{String.Join(", ", CopyofArray(GetArray(size)))}");


// Решение другой группы
// int[] Massive()
// {
//     System.Console.WriteLine("Введите размерность массива: ");

//     int i1 = Convert.ToInt32(Console.ReadLine());

//     int[] mass = new int[i1];

//     for (int i = 0; i < mass.Length; i++)
//     {
//         mass[i] = new Random().Next(-10, 10);
//     }
//     System.Console.WriteLine(String.Join(",", mass));

//     int[] mass1 = new int[i1];

//     for (int j = 0; j < mass1.Length; j++)
//     {
//         mass1[j] = mass[j];
//     }
//     System.Console.WriteLine(String.Join(",", mass1));
//     return mass1;
// }
// Massive();