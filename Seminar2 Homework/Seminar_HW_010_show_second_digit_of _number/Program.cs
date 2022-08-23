// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 100 && Number <= 999)
{
    int Second_digit_of_number = (Number / 10) % 10;
    Console.WriteLine($"Second digit of this number is {Second_digit_of_number}");
}
else
{
    Console.WriteLine($"This number not a three-digit number");
}