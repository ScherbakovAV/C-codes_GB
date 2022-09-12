// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int EndNumber;
int StartNumber = 1;

do
{
    try
    {
        Console.Write("Enter a number... ");
        EndNumber = Convert.ToInt32(Console.ReadLine());
        break;          
    }
    catch (FormatException)
    {
        Console.WriteLine("Wrong format");
    }
}
while(true);

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
    Console.WriteLine("The number is negative, program shutdown");
}

// Решение учителя

// Console.Write("Enter a number...");
// int EndNumber = Convert.ToInt32(Console.ReadLine());

// 1 вариант:

// for (int i = 2; i <= EndNumber; i +=2)
// {
//     Console.Write(i + " ")
// }

// 2 вариант:

// for (int i = 1; i <= EndNumber; ++i)
// {
//     if (i % 2 == 0) Console.Write(i + " ")
// }