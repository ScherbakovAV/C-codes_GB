// Изменить решение последней задачи под сортироку в обратном порядке

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
        int maxPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

System.Console.WriteLine("Массив до преобразования:");
PrintArray(arr);
SelectionSort(arr);

System.Console.WriteLine("Cортированный массив в обратном порядке:");
PrintArray(arr);