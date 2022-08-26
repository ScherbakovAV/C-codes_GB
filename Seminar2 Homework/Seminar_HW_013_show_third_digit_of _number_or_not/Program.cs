// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Number = new Random().Next(-1000000, 1000000);

Console.WriteLine("Your random number is "+Number);

if (Number >= 100)
{
    Console.WriteLine("Third digit of this number is "+Convert.ToString(Number)[2]);
}

else if (Number <= -100)
{
    Console.WriteLine("Third digit of this number is "+Convert.ToString(Number)[3]);
}

else
{
    Console.WriteLine($"There is no third digit in this number");
}