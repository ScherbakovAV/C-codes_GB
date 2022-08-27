// ___Виды методов (условные)___ 

// Вид 1 (ничего не принимает и ничего не возвращает)
// _________________________________________________________________________________

void Method1()
{
    System.Console.WriteLine("Autor ...");
}

Method1(); // вызов метода - скобки обязательны
// _________________________________________________________________________________


// Вид 2 (принимает, но ничего не возвращает)
// _________________________________________________________________________________

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("Message...");

// _________________________________________________________________________________

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++; // инкремент декремент
    }
    
}

Method21("Message2...", 4);
// можно так:
// Method21(msg: "Message2...", count: 4);
// в таком случае необязательно, чтобы аргументы шли по порядку:

Method21(count: 2, msg: "Message3...");

// _________________________________________________________________________________


// Вид 3  (ничего не принимает, что-то возвращает)
// _________________________________________________________________________________

int Method3() //обязательно указывать тип возвращаемых данных
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

// _________________________________________________________________________________


// Вид 4  (принимает и возвращает)
// _________________________________________________________________________________

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //обозначение пустой строки - так лучше, чем ""

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Text_ new");
System.Console.WriteLine(res);
// _________________________________________________________________________________

//через for
// _________________________________________________________________________________

string Method41(int count, string text)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res1 = Method41(10, "Text_ for");
System.Console.WriteLine(res1);

// _________________________________________________________________________________


// ___цикл в цикле___
// _________________________________________________________________________________

for(int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        System.Console.WriteLine(($"{i} x {j} = {i * j}"));
    }
    System.Console.WriteLine();
}

// _________________________________________________________________________________


// ___Задача___
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// _________________________________________________________________________________

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] -> r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);

// _________________________________________________________________________________


// ___сортироовка массива методом выбора___
// _________________________________________________________________________________

int[] arr = {1, 5, 4, 3, 5, 8, 4, 3, 5, 6, 7, 9};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

// _________________________________________________________________________________