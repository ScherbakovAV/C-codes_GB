﻿// 12. Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// Сначала примем и проверим первое число, не будем рассчитывать это для отрицательных чисел, только для положительных и 0

// кому не даются првоерки или не нужны, используйте int number1 = Convert.ToInt32(Console.ReadLine()); и Console.WriteLine("Введите первое чсило: ");
// а также закомментируйте циклы
int number1, number2;

// В цикле будем проверять ввод, пока он не будет верным
while(true){
    Console.Write("Введите первое целое число: ");
    // Вот тут объявлем строковую перемнную strNumber, куда пишем ввод пользователя
    string? consoleStr = Console.ReadLine();
    // а здесь вместо try - catch знакомые уже if - else
    // int.TryParse - метод, преобразующий строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. 
    // Возвращает значение, указывающее, успешно ли выполнена операция. Т.е. тут работает Булева логика
    // если преобразование прошло успешно - тогда вренется true и значение будет записано в переменную number
    // если преобразование не успешно - получим false и в переменную number записано ничего не будет
    // Если TryParse успешен, значит в number1 у нас целое число, но мы не знает с каким знаком
    if(int.TryParse(consoleStr, out number1)){
        if(number1 >= 0)
        {
            // если в number1 число больше 0 - завершаем цикл через break
            break;
        }
        else
        {
            // если полученное число меньше 0 - цикл продолжим и скажем, что есть число, но не положительное
            Console.WriteLine("Число отрицательное. Введите положительное число.");
        }
    }
    else{
        // если TryParse вернул false - продолжаем цикл
        Console.WriteLine("Неверный формат ввода. Введите число");
    }
}

// То же самое делаем для вторго числа. Обратите внимание - в рамках цикла используется одинаковая переменная string consoleStr.
// Но поскольку она объявлена только в пределах цикла, только там она и вычисляется. Как завершается цикл - переменная очищается
// А переменные int number1, number2; объявлены за пределами цикла и в циклах мы в них что-то пишем. По завершении в них останется значение
while(true){
    Console.Write("Введите второе целое число: ");
    // Вот тут объявлем строковую перемнную strNumber, куда пишем ввод пользователя
    string? consoleStr = Console.ReadLine();
    // а здесь вместо try - catch знакомые уже if - else
    // int.TryParse - метод, преобразующий строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. 
    // Возвращает значение, указывающее, успешно ли выполнена операция. Т.е. тут работает Булева логика
    // если преобразование прошло успешно - тогда вренется true и значение будет записано в переменную number
    // если преобразование не успешно - получим false и в переменную number записано ничего не будет
    // Если TryParse успешен, значит в number1 у нас целое число, но мы не знает с каким знаком
    if(int.TryParse(consoleStr, out number2)){
        if(number2 >= 0)
        {
            // если в number1 число больше 0 - завершаем цикл через break
            break;
        }
        else
        {
            // если полученное число меньше 0 - цикл продолжим и скажем, что есть число, но не положительное
            Console.WriteLine("Число отрицательное. Введите положительное число.");
        }
    }
    else{
        // если TryParse вернул false - продолжаем цикл
        Console.WriteLine("Неверный формат ввода. Введите число");
    }
}

// Получили оба числа для решения задачи
// Проыверим на кратность второе число. Кратное число – это число, делящееся на целое число без остатка.
// Некоторый подвох в задаче - первое число должно быть меньше, т.к. оно в логике выступает в роли делителя

if(number2 % number1 == 0)
{
    //Если поделили бкз остатка
    Console.WriteLine($"Число {number2} кратное {number1}");
}
else
{
    // Иначе число не кратно, выводим остаток
    // ну и сделаем переменную, куда запишем остаток
    int result =  number2 % number1;
    Console.WriteLine($"Число {number2} не кратное {number1}, остаток {result}");
}

// теперь метод, который на вход принимает каких-то два агрумента типа int (работаем то с 2-мя числами) и возвращает строку (string)

string ResultDivision (int arg1, int arg2)
{
    // присваиваем агрументам числа, которые ввели
    arg1 = number1;
    arg2 = number2;
    // объявляем стркоовую переменную, куда запишем результат
    string res;

    if(arg2 % arg1 == 0)
    {
        // в res пишем строку с переданными значениями переменных
        res = $"Число {arg2} кратное {arg1}";
    }
    else
    {
        int result =  arg2 % arg1;
        // в res пишем строку с переданными значениями переменных с учетом остатка
        res = $"Число {arg2} не кратное {arg1}, остаток {result}";
    }
    // Выводи все в ретурн
    return res;
}
// Результат метода можно извлечь сразу в консоль - ниже пример вывода метода в консоль
Console.WriteLine($"{ResultDivision(number1, number2)} - это результат метода");