// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number...");
int EndNumber = Convert.ToInt32(Console.ReadLine());
int StartNumber = 1;
while (StartNumber <= EndNumber)
{
    if (StartNumber % 2 == 0)
    {
        Console.Write(StartNumber + " ");
        // Console.Write ($"{StartNumber}, ");
    }
    ++StartNumber;
}