// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
int mult = 1;

for(int i = 1; i <= number; i++)
{
    mult = mult * i;
}

System.Console.WriteLine($"Multiplication of numbers of 1 to {number} is {mult}");