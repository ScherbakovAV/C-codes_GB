// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.Write("Enter a number...");
int number = Convert.ToInt32(Console.ReadLine());
int count;

for(count = 1; number / 10 > 0; count++)
{
    number = number / 10;
}

System.Console.WriteLine($"Number of digits is {count}");

// System.Console.WriteLine($"Numbers of digits is... {i}");

// int GetDigitsCount(int x)
// {
//     int count = 1;
//     while ((x /= 10) > 0) ++count;
//     return count;
// }
