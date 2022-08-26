// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// AB = sqrt((Xb - Xa)^2 + (Ya - Yb)^2

Console.WriteLine("Введите координату первой точки по оси X...");
double Xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату первой точки по оси Y...");
double Ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси X...");
double Xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси Y...");
double Yb = Convert.ToDouble(Console.ReadLine());

double Distance = Math.Sqrt((Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2)));
Console.WriteLine("Расстояние между двумя точками равно: " + Distance);


// Console.WriteLine("Enter x1...");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2...");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// int y2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

// // Console.WriteLine("длинна отрезка"+result);

// Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {result}");


// double GetDistance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// }