int[] array = { 51, 48, 96, 62, 87, 1, 96, 78 };

int n = array.Length;
int find = 96;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // чтобы поиск останавливался при первом же результате, если есть одинаковые элементы массива 
    }
    index++;
}