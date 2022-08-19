// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Enter number 1...");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2...");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number ...");
int Number3 = Convert.ToInt32(Console.ReadLine());
int MaxNumber = Number1;

if (Number2 > MaxNumber)
{
    MaxNumber = Number2;
}
if (Number3 > MaxNumber)
{
    MaxNumber = Number3;
}
Console.Write("Max number is " + MaxNumber);
