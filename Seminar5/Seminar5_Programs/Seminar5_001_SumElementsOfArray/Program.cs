// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

string SummOfNumbers()
{
    int[] array = new int[12];

    int sumPositive = 0;
    int sumNegative = 0;
    int result;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);

        result = (array[i] > 0) ? (sumPositive += array[i]) : (sumNegative += array[i]);
    }

    string output = $"You array: {String.Join(", ", array)}\nSumm of positive numbers of array is {sumPositive}\nSumm of positive numbers of array is {sumNegative}";;

    return output;
}

System.Console.WriteLine(SummOfNumbers());