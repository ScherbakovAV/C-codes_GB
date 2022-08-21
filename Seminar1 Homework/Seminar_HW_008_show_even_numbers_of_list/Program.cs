// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number...");
int EndNumber = Convert.ToInt32(Console.ReadLine());
int StartNumber = 1;
if (EndNumber > 0)
{
    Console.WriteLine("Even numbers from zero to entered number is:");
    while (StartNumber <= EndNumber)
    {
        if (StartNumber % 2 == 0)
        {
            Console.Write(StartNumber + " ");
            // Console.Write ($"{StartNumber}, ");
        }
        ++StartNumber;
    }
}
else
{
    Console.WriteLine("Wrong number");
}