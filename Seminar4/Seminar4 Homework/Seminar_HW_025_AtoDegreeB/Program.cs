// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumberAToPowerB()
{
    double numberA;
    double numberB;

    do
    {
        try    
        {
            Console.WriteLine("Enter number A...");
            numberA = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter number B...");
            numberB = Convert.ToDouble(Console.ReadLine());
            break;
        }

        catch (FormatException)
        {
            Console.WriteLine($"Wrong format! Enter a correct numbers!\nTry again...");
            Console.WriteLine("");
        }
    }
    while(true);

    double powA = Math.Pow(numberA, numberB);

    Console.Write($"{numberA} to the power of {numberB} is ");

    return powA;
}

Console.Write($"{NumberAToPowerB():f3}");