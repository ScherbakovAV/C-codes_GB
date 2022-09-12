// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Enter number 1...");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2...");
int Number2 = Convert.ToInt32(Console.ReadLine());
int MaxNumber = 0;

if (Number1 > Number2)
{
    MaxNumber = Number1;
    Console.Write("Max number is " + MaxNumber);
}
if (Number1 < Number2)
{
    MaxNumber = Number2;
    Console.Write("Max number is " + MaxNumber);
}
if (Number1 == Number2)
{
    Console.Write("These numbers are equal");
}
