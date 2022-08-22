// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

Console.WriteLine("Enter a first number: ");
int Number1 = Convert.ToInt32(Console.ReadLine()); // или int.Parse
Console.WriteLine("Enter a second number: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 > Number1)
{
    if (Number2 % Number1 == 0)
    {
        Console.WriteLine("Second number is a multiple of first number");
    }
    else
    {
        Console.WriteLine("Second number is not multiple of first number");
        Console.WriteLine("remainder of the division is "+(Number2 % Number1));
    }
}
else
{
    if (Number1 % Number2 == 0)
    {
        Console.WriteLine("First number is a multiple of second number");
    }
    else
    {
        Console.WriteLine("First number is a not multiple of second number");
        Console.WriteLine("remainder of the division is "+(Number1 % Number2));
    }
}