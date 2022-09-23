// Решение задач итеративным подходом и рекурсией


// Задача 1а - собрать строку с числами от a до b, a <= b

string NumbersForAB(int a, int b) // итеративный подход
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecAB(int a, int b) // рекурсивный подход
{
    if (a <= b) return $"{a} " + NumbersRecAB(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersForAB(1, 10));
Console.WriteLine(NumbersRecAB(1, 10));


// Задача 1б - собрать строку с числами от b до a, a <= b

string NumbersForBA(int a, int b) // итеративный подход
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecBA(int a, int b) // рекурсивный подход
{
    if (a == b) return $"{a} "; // моё дополнение для уменьшения вызова рекурсии на 1
    if (a < b) return NumbersRecBA(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersForBA(1, 10));
Console.WriteLine(NumbersRecBA(1, 10));


// Задача 2 - сумма от 1 до n

int SumFor(int n) // итеративный подход
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n) // рекурсивный подход
{
    if (n == 1) return 1;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));


// Задача 3 - факториал

int FactFor(int n) // итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactRec(int n) // рекурсивный подход
{
    if (n == 1) return 1;
    else return n * FactRec(n - 1);
}

Console.WriteLine(FactFor(5));
Console.WriteLine(FactRec(5));


// Задача 4 - вычисление a^n

int PowerFor(int a, int n) // итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n) // рекурсивный подход
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n) // рекурсивный подход
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(3, 5));
Console.WriteLine(PowerRec(3, 5));
Console.WriteLine(PowerRecMath(3, 5));


// Задача 5 - перебор слов
// есть 4 буквы (а, и, с, в). Показать все слова, состоящие из n букв,
// которые можно построить из букв этого алфавита

char[] s = { 'а', 'и', 'с' }; // итеративный подход
int count = s.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
}

n = 1;

void FindWords(string alphabet, char[] word, int length = 0) // рекурсивный подход
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аис", new char[3]);


// Задача 6 - алгоритм обхода территории

string path = @"D:\Geek Brains\8 - Знакомство с языками программирования"; // итеративный подход
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "") // рекурсивный подход
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
CatalogInfo(path);


// Задача 7 - игра в пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}


/* Задача 8 - обход разных структур
((4 - 2) * (1 + 3)) / 10
-->>>
            /
       *       10  
  -        +
4   2    1   3 
*/

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();