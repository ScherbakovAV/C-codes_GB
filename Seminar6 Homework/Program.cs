/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.Clear();

Console.WriteLine("\n_____Seminar 6 Homework: exercise #41_____\n");

int[] arrayCicle = ArrayFromUserCicle(5); // первый вариант ввода чисел с клавиатуры
Console.WriteLine($"Количество положительных чисел в этом ряду = {CountOfPositiveNumbersInArray(arrayCicle)}\n");

int[] arrayConvert = ArrayFromUserConvertString(); // второй вариант ввода чисел с клавиатуры
Console.WriteLine($"Количество положительных чисел в этом ряду = {CountOfPositiveNumbersInArray(arrayConvert)}\n");

// ListFromUserCicleAndStop(); // третий вариант ввода чисел с клавиатуры (3001)

int[] ArrayFromUserCicle(int countOfNumbers)
{
    Console.WriteLine($"<Первый вариант ввода чисел>\nВведите {countOfNumbers} целых чисел...");

    int[] arrayEnteredNumbers = new int[countOfNumbers];

    for (int i = 0; i < countOfNumbers; i++)
    {
        arrayEnteredNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"Введённые числа: [{String.Join(", ", arrayEnteredNumbers)}]");

    return arrayEnteredNumbers;
}

int[] ArrayFromUserConvertString()
{
    Console.Write($"<Второй вариант ввода чисел>\nВведите любое количество целых чисел через пробел...");

    int[] arrayFromString = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

    // решение группы 3001:
    // string[] nums = stringArray.Split(' ');
    // int[] arrayFromString = new int[nums.Length];
    // for (int i = 0; i < arrayFromString.Length; i++)
    // {
    //     arrayFromString[i] = Convert.ToInt32(nums[i]);     
    // }

    return arrayFromString;
}

// Через стоп-слово (группа 3001)

// int[] ListFromUserCicleAndStop()
// {
//     Console.WriteLine($"<Третий вариант ввода чисел>\nВведите любое количество целых чисел через пробел.");
//     Console.WriteLine("Для остановки введите stop");

//     List<int> arr = new List<int>();

//     while(true)
//     {
//         string input = Console.ReadLine()!;

//         if (input == "stop") break;

//         else arr.Add(Convert.ToInt32(input));
//     }

//     Console.Write("Введённые числа: ");

//     foreach (var item in arr)
//     {
//         Console.Write($"{item}, ");        
//     }

//     Console.WriteLine();

//     return arr(); // Как возвращать List и как его вызывать?
// }

int CountOfPositiveNumbersInArray(int[] array)
{
    int countOfPositiveNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) countOfPositiveNumbers++;
    }

    // или так (у 3001):
    // foreach (var item in array)
    // {
    //     if (item > 0)
    //     {
    //         countOfPositiveNumbers++;
    //     }
    // }

    return countOfPositiveNumbers;
}



/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("_____Seminar 6 Homework: exercise #43_____\n");

PointOfIntersectionOfTwoLines();

void PointOfIntersectionOfTwoLines()
{
    Console.WriteLine("Даны две прямые, описанные уравнениями y = k1 * x + b1, y = k2 * x + b2.");

    Console.WriteLine("Введите переменную первого уравнения k1...");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите переменную первого уравнения b1...");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите переменную второго уравнения k2...");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите переменную второго уравнения b2...");
    double b2 = Convert.ToDouble(Console.ReadLine());

    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;

    Console.WriteLine($"Координаты точки пересечения этих прямых: ({Math.Round(x, 3)}; {Math.Round(y, 3)})");
}

// Через массив (3001)

Console.WriteLine("Вариант 2... Введите переменные через пробел:");

string[] stringArray = Console.ReadLine()!.Split(' ');

double k1 = double.Parse(stringArray[0]);
double b1 = double.Parse(stringArray[1]);
double k2 = double.Parse(stringArray[2]);
double b2 = double.Parse(stringArray[3]);

double[] GetPoint(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];

    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k1 * result[0] + b1;

    return result;
}

Console.WriteLine(string.Join(" ", GetPoint(k1, b1, k2, b2)));
