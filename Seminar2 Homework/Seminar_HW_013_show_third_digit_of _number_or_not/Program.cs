// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Number = new Random().Next(-1000000, 1000000);

// Console.WriteLine("Your random number is "+Number);

// if (Number >= 100)
// {
//     Console.WriteLine("Third digit of this number is "+Convert.ToString(Number)[2]);
// }

// else if (Number <= -100)
// {
//     Console.WriteLine("Third digit of this number is "+Convert.ToString(Number)[3]);
// }

// else
// {
//     Console.WriteLine($"There is no third digit in this number");
// }


// ___Решение через метод___
//
// int GetThirdDigit(int number)
// {
//     if (number < 100)
//     {
//         System.Console.WriteLine(("Третьей цифры нет"));
//         return 0;
//     }
//     int result = 0;
//     while (number >999)
//     {
//         number /= 10;
//         result = number % 10;
//     }

//     return result;
// }

// System.Console.WriteLine(GetThirdDigit(56488313));


// ___Решение через массив (для  этого решения не оптимально)___
//
// int GetThirdDigit(int number)
// {
//     int[] arr = new int[7];

//     for (int i = 0; number > 0; i++)
//     {
//         arr[i] = number % 10;
//         number /= 10;
//     }

//     return arr[arr.Length - 3];
// }

// System.Console.WriteLine(GetThirdDigit(4612166));


// ___Решение через строки___
//
// System.Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// System.Console.WriteLine(number[2]);
