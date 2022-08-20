// Console.Write("Введите номер дня недели...");
// int Day = Convert.ToInt32(Console.ReadLine());
// if (Day == 1)
// {
//     Console.Write("Первый день недели - понедельник");
// }
// if (Day == 2)
// {
//     Console.Write("Второй день недели - вторник");
// }
// if (Day == 3)
// {
//     Console.Write("Третий день недели - среда");
// }
// if (Day == 4)
// {
//     Console.Write("Четвёртый день недели - четверг");
// }
// if (Day == 5)
// {
//     Console.Write("Пятый день недели - пятница");
// }
// if (Day == 6)
// {
//     Console.Write("Шестой день недели - суббота");
// }
// if (Day == 7)
// {
//     Console.Write("Седьмой день недели - воскресенье");
// }
// if (Day > 7)
// {
//     Console.Write("Такого дня недели нет!");
// }

//Решение лектора:

Console.Write("Enter number...");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    switch (number)
    {
        case 1:
            Console.Write("Monday");
            break;
        case 2:
            Console.Write("Tuesday");
            break;
        case 3:
            Console.Write("Wednesday");
            break;
        case 4:
            Console.Write("Thursday");
            break;
        case 5:
            Console.Write("Friday");
            break;
        case 6:
            Console.Write("Saturday");
            break;
        case 7:
            Console.Write("Sunday");
            break;
    }
}
else
{
    Console.Write("Bad number!");
}