// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Enter day number...");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 5)
{
    Console.WriteLine("This day is not holiday");
}
else if (number == 6 || number == 7)
{
    Console.Write("This is holiday!!!");
}
else
{
    Console.Write("Wrong number...");
}


// Через метод boolean
//
// bool IsWeekend(int number)
// {
//     if (number >7 || number < 1)
//     {
//         return false;
//     }
//     if (number > 5)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Введите число...");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(IsWeekend(number));

// ________________________________________________
// Решение Максима:

// Console.Write("Введите день недели: ");

// int[] weekDays = { 1, 2, 3, 4, 5, 6, 7 };
// int DayNum = weekDays.Length;

// DayNum = Convert.ToInt32(Console.ReadLine()) -1;

// if (weekDays[DayNum] == 6 || weekDays[DayNum] == 7)
// {
//     Console.WriteLine("Да. Выходной день недели.");
// }
// else
// {
//     Console.WriteLine("Нет. Рабочий день недели.");
// }

// Моя переработка:

// Console.Write("Введите день недели: ");

// int[] weekDays = { 1, 2, 3, 4, 5, 6, 7 };

// int DayNum = Convert.ToInt32(Console.ReadLine());

// if (weekDays[6] == DayNum || weekDays[5] == DayNum)
// {
//     Console.WriteLine("Да. Выходной день недели.");
// }
// else
// {
//     Console.WriteLine("Нет. Рабочий день недели.");
// }