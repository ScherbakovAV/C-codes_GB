// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummOfDigitsInNumber(int num)
{
    int summ = 0;

    for (int i = 0; num > 0; i++)
    {
        summ += num % 10;
        num = num / 10;
    }
    
    return summ;
}

Console.WriteLine("Enter a string number");

int number = SummOfDigitsInNumber(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Summ of digits of this number is {number}");


// Второй вариант, через строку.

// int SummOfDigitsInNumber(string num)
// {
//     int summ = 0;

//     for (int i = 0; i < num.Length; i++)
//     {
//         summ = summ + Convert.ToInt32(Char.GetNumericValue(num[i]));
//     }
    
//     return summ;
// }

// Console.WriteLine("Enter a string number");

// int summ = SummOfDigitsInNumber(Console.ReadLine()!);

// Console.WriteLine($"Summ of digits of this number is {summ}");