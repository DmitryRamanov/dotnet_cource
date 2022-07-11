// Задача 1: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateEmptyArray(int length)
{
    return new int[length];
}

void FillRandomArray(int[] array, int minBorderValue, int maxBorderValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minBorderValue, maxBorderValue);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ReversArray(int[] array)
{
    int arrayLength = array.Length;
    for (int i = 0; i < arrayLength / 2; i++)
    {
        int tempValue = array[i];
        array[i] = array[arrayLength - i - 1];
        array[arrayLength - i - 1] = tempValue;
    }
}

int[] orignArray = CreateEmptyArray(8);
FillRandomArray(orignArray, 1, 10);
PrintArray(orignArray);
ReversArray(orignArray);
Console.Write("-> ");
PrintArray(orignArray);