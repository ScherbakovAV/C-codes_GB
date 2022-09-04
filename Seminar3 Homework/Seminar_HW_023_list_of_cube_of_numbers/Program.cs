// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter a number...");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сubes of numbers from 1 to a given number: ");

for(int i = 1; i <= Number; i++)
{
    if (i != Number)
    Console.Write($"{Math.Pow(i, 3)}, ");
    if (i == Number)
    Console.Write($"{Math.Pow(i, 3)}\n");
}


// Решение лектора группы 3001

double[] GetCubes(int n)
{
    double[] arr = new double[n];

    for (int i = 1; i <= arr.Length; i++)
    {
        arr[i - 1] = Math.Pow(i, 3);       
    }

    return arr;
}

foreach (var item in GetCubes(10))
{
    System.Console.WriteLine(item);
}