Console.Write("Введите трёхзначное число...");
int number = Convert.ToInt32(Console.ReadLine());

if((number > 99) && (number < 1000))
{
    Console.Write("Последняя цифра числа - ");
    Console.WriteLine(number % 10);
}
else
{
    Console.Write("Вы ввели не трёхзначное число");
}