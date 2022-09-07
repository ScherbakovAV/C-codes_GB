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

int[] ArrayFromUserCicle(int countOfNumbers)
{
    Console.WriteLine($"<Первый вариант ввода чисел>\nВведите {countOfNumbers} целых чисел...");

    int[] arrayEnteredNumbers = new int [countOfNumbers];

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

    return arrayFromString;
}

int CountOfPositiveNumbersInArray(int[] array)
{
    int countOfPositiveNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) countOfPositiveNumbers++;
    }

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