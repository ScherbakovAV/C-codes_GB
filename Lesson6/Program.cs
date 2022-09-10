// Задача: в этой строке увеличить все координаты в 2 раза

// using System.Linq;

// string text = "(1,2) (3,4) (5,6) (7,8)";

// var data = text.Split(" ")
//                 .ToArray();

// for (int i = 0; i < data.Length; i++)
// {
//     Console.WriteLine(data[i]);
// }

// Console.WriteLine();

// На этом этапе выводятся подстроки типа string

// using System.Linq;

// string text = "(1,2) (3,4) (5,6) (7,8)"
//             .Replace("(", "") 
//             .Replace(")", "") // убираем скобки
//             ;
// var data = text.Split(" ")
//                 .Select(item => item.Split(',')) // разбиваем каждый набор координат в отдельный массив
//                 .ToArray(); // получаем массив массивов

// for (int i = 0; i < data.Length; i++)
// {
//     for (int k = 0; k < data[i].Length; k++)
//     {
//         Console.WriteLine(data[i][k]);  // обращение к массиву подмассива - это ещё строки          
//     }
//     Console.WriteLine();
// }
// На этом этапе ещё выводятся строки

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "") 
            .Replace(")", "") 
            ;
Console.WriteLine(text);

var data = text.Split(" ") // разбиение текста пробелом
                .Select(item => item.Split(',')) // делаем выборку элементов с разделителем , 
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // делаем выборку и массив превращаем в кортеж чисел
                .Where(e => e.x % 2 == 0) // делаем проверку условие, где 1 координата чётная
                .Select(point => (point.x * 10, point.y)) // менчем 1 оординату
                .ToArray(); // пренвращаем в явный массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);          
}

// Тут уже выводятся числа
