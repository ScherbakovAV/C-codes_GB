// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine($"Enter the X coordinate of the first point...");
double Xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter the Y coordinate of the first point...");
double Ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter the Z coordinate of the first point...");
double Za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter the X coordinate of the second point...");
double Xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter the Y coordinate of the second point...");
double Yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter the Z coordinate of the second point...");
double Zb = Convert.ToDouble(Console.ReadLine());

double Distance = Math.Sqrt((Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2)));
Console.WriteLine($"The distance between two points in 3D space is: {Distance:f3}");
