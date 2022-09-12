// Написать программу, которая выдаёт случайное число из отрезка и показывает наибольшую цифру числа.

// Решение преподавателя в моей переработке.

static int MaxNumber() // статический метод
{
    int number1 = new Random().Next(10, 1000000);
    int max = 0;
    int iterator = number1;

    Console.WriteLine("Случайное число от 10 до 999999 - "+number1);

    while(iterator != 0)
    {
        int number2 = iterator % 10;

        if (number2 > max) max = number2;

        iterator /= 10;
        // iterator = iterator / 10
    }

    return max;

}

    Console.WriteLine("Максимальная цифра этого числа - "+MaxNumber());

// Второй вариант решения:
// static void MaxNumber2()
//         {
//             int number = new Random().Next(10, 100);
//             int number1 = number % 10;
//             int number2 = number / 10;

//             int max = number1;

//             if (number1 < number2)
//             {
//                 max = number2;
//             }
//             System.Console.WriteLine($"Number {number} Max {max}");
//         }