// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> 

// _____________________________________________________________
// 1. Отправленное на проверку:

// int[] array = {0, 0, 0, 0, 0};

// Console.WriteLine("Enter the first number of the array... ");
// array[0] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number of the array... ");
// array[1] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number of the array... ");
// array[2] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number of the array... ");
// array[3] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number of the array... ");
// array[4] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your array is: " + array[0] + array[1] + array[2] + array[3] + array[4]);

// if ((array[0] == array[4]) && (array[1] == array[3]))
// {
//     Console.WriteLine("This number is palindrome!");
// }
// else
// {
//     Console.WriteLine("This number is normal");
// }

// _____________________________________________________________

// 2. Решение двумя методами через массив для любой длины строки с заданием массива циклом 

char[] TextToArray()
{
    Console.WriteLine("Enter a text or a number... ");
    string arrText = Console.ReadLine()!;

    arrText = arrText.ToLower().Replace(" ", "");
    
    char[] array = arrText.ToCharArray();

    return array;
}

string ArrayCheckForPalindrome(char[] array)
{
    int check = 0;

    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i]) check++;
    }

    string result;

    if (check == array.Length / 2)
    {
        result = "This is a palindrome";
    }
    else
    {
        result = "This is NOT a palindrome!";
    }

    return result;
}

char[] arrayText = TextToArray();

System.Console.WriteLine(ArrayCheckForPalindrome(arrayText));

// _____________________________________________________________

// 3. Решение методом через через строку

// void StrCheckForPalindrome()
// {
//     Console.WriteLine("Enter a text or a number... ");
//     string Text = Console.ReadLine()!;

//     Text = Text.ToLower().Replace(" ", "");

//     int check = 0;

//     for (int i = 0; i < Text.Length / 2; i++)
//     {
//         if (Text[i] == Text[Text.Length - 1 - i]) check++;
//     }

//     if (check == Text.Length / 2)
//     {
//         System.Console.WriteLine("This is a palindrome");
//     }
//     else
//     {
//         System.Console.WriteLine("This is NOT a palindrome!");
//     }
// }

// StrCheckForPalindrome();