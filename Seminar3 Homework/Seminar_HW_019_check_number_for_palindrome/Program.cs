// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> 

// Отправленное на проверку:

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


void NumberCheckForPalindrome()
{
    Console.WriteLine("Enter a number to check for a palindrome... ");
    string arrText = Console.ReadLine()!;

    int arrLenght = arrText.Length;
    int[] array = new int[arrLenght];

    
    // Console.WriteLine("Your array is: ");

    for(int j = 0; j < arrLenght; j++)
    {
        array[j] = Convert.ToInt32(arrText[j]);
    // Console.Write($"{array[j]} "); // для проверки
    // System.Console.WriteLine("");
    }

    int check = 0;

    for (int i = 0; i < arrLenght / 2; i++)
    {
        if (array[i] == array[arrLenght - 1 - i]) check++;
    }
  
    if (check == arrLenght / 2)
    {
        System.Console.WriteLine("This number is a palindrome");
    }
    else
    {
        System.Console.WriteLine("It is NOT a palindrome!");
    }
}

NumberCheckForPalindrome();