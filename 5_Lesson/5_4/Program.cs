/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int[] CreateNewArray(int arrayLength)
{
    return new int[arrayLength];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetNumberOfArrayElementsInBorders(int minBorder, int maxBorder, int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minBorder && array[i] <= maxBorder)
        {
            result++;
        }
    }    
    return result;
}

int minBorder = 80;
int maxBorder = 99;
int[] array = CreateNewArray(20);
FillArray(array);
PrintArray(array);
Console.WriteLine($"-> {GetNumberOfArrayElementsInBorders(minBorder,maxBorder,array)}");