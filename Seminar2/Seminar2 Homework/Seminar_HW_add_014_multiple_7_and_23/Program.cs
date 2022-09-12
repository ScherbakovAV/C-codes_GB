// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

String CheckForMultiple(int Number1, int Number2)
{
string result = "";    
if (Number1 % Number2 == 0)
    {
        result = "yes";
    }
    else
    {
        result = "no";
    }
return result;    
}

Console.WriteLine("Enter a number...");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = 7;
int Num3 = 23;
String CheckFor7 = CheckForMultiple(Num1, Num2);
String CheckFor23 = CheckForMultiple(Num1, Num3);
if (CheckFor7 == "yes" && CheckFor23 == "yes")
{
    Console.WriteLine($"Your number {Num1} is multiple of 7 and 23");
}
else
{
    Console.WriteLine($"Your number {Num1} is NOT multiple of 7 and 23");
}
