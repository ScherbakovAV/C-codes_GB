//HW5
Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("34) Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        System.Console.WriteLine("36) Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        System.Console.WriteLine("37) Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
        System.Console.WriteLine("38) Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: break;
            case 34:
                Console.Clear();
                int[] startArray = GetArray(12, 100, 999);
                Console.WriteLine(String.Join(" ", startArray));
                Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");
                break;
            case 36:
                Console.Clear();
                startArray = GetArray(6, 0, 999);
                Console.WriteLine(String.Join(" ", startArray));
                Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");

                break;

            case 37:

                Console.Write("Введите элементы массива через пробел: ");
                string elements = Console.ReadLine();
                int[] baseArray = GetArrayFromString(elements);
                Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

                break;

            case 38:
                Console.Clear();
               double[] startArrayDouble = GetArrayDouble(6, 0, 999);
                Console.WriteLine(String.Join(" ", startArrayDouble));
                Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");
                break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    var random = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = random.Next(minValue, maxValue + 1) + random.NextDouble();
    }
    return res;
}

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
int GetEvenCount(int[] array)
{
    int count = 0;
    //[4,5,6,14]
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}


//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}


int[] ResultArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 == 1) size++;

    int[] result = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {

        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];

    return result;
}