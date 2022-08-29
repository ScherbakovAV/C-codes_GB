// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
int summ = 0;

for(int i = 1; i <= number; i++)
{
    summ = summ + i;
}

System.Console.WriteLine($"Summ of numbers of 1 to {number} is {summ}");
