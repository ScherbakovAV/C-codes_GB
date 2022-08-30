// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumberAToPowerB()
{
    double numberA;
    double numberB;

    Console.WriteLine("Enter number A...");

    do
    {
        try    
        {
            numberA = Double.Parse(Console.ReadLine()!);
            break;
        }

        catch (FormatException)
        {
            Console.Write("Wrong format! Enter a correct number A...");;
        }
    }
    while(true);

    Console.WriteLine("Enter number B...");

    do
    {
        try    
        {
            numberB = Double.Parse(Console.ReadLine()!);
            break;
        }

        catch (FormatException)
        {
            Console.Write("Wrong format! Enter a correct number B...");;
        }
    }
    while(true);
    
    double powA = Math.Pow(numberA, numberB);

    Console.Write($"{numberA} to the power of {numberB} is ");

    return powA;
}

Console.Write($"{NumberAToPowerB():f3}");