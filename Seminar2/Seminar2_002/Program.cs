// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int Number = new Random().Next(100, 1000);
// Console.WriteLine("This number is " + Number);
// int Digit3 = Number % 10;
// int Digit1 = Number / 100;
// Console.WriteLine("First and third digits of this number are "+Digit1+Digit3);

// решение учителя

int number = new Random().Next(100, 1000);

int result = ((number / 100) * 10) + (number %10);

Console.WriteLine($"Number = {number}; result = {result} ");