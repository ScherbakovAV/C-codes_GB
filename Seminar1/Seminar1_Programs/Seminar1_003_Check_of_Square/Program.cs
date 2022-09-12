Console.Write("Введите число 1...");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2...");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 == Number2 * Number2)
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число НЕ является квадратом второго");
}