﻿// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


Console.Write("Введите координату точки по оси X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Эта точка находится в 1 четверти координатной плоскости");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Эта точка находится во 2 четверти координатной плоскости");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Эта точка находится в 3 четверти координатной плоскости");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Эта точка находится в 4 четверти координатной плоскости");
}