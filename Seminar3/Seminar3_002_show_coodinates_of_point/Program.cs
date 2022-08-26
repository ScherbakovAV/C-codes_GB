// Задача 18: Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int Quarter = Convert.ToInt32(Console.ReadLine());


switch(Quarter)
{
    case 1:
    System.Console.WriteLine("В первой четверти X>0 и Y>0");
    break;

    case 2:
    System.Console.WriteLine("Во второй четверти X<0 и Y>0");
    break;

    case 3:
    System.Console.WriteLine("В третьей четверти X<0 и Y<0");
    break;

    case 4:
    System.Console.WriteLine("В четвёртой четверти X>0 и Y<0");
    break;
}

// if (Quarter == 1)
// {
//     Console.WriteLine("В первой четверти X>0 и Y>0");
// }

// else if (Quarter == 2)
// {
//     Console.WriteLine("Во второй четверти X<0 и Y>0");
// }

// else if (Quarter == 3)
// {
//     Console.WriteLine("В третьей четверти X<0 и Y<0");
// }

// else if (Quarter == 4)
// {
//     Console.WriteLine("В четвёртой четверти X>0 и Y<0");
// }

// _________________________________________________________

// Console.WriteLine("Enter quater... ");
// int quaternumber = int.Parse(Console.ReadLine());
// if (quaternumber == 1)
// {
//     Console.WriteLine("x > 0, y > 0");

// }
// else if (quaternumber == 2)
// {
//     Console.WriteLine("x < 0, y > 0");

// }
// else if (quaternumber == 3)
// {
//     Console.WriteLine("x < 0, y < 0");

// }
// else if (quaternumber == 4)
// {
//     Console.WriteLine("x > 0, y < 0");

// }
// else
// {
//     Console.WriteLine("Bug Error");
// }