/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] CreateNewArray(int arrayLength)
{
    return new int[arrayLength];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] ProductOfPairsOfNumbersInArray(int[] originalArray)
{
    int oLength = originalArray.Length;
    int[] result = new int[oLength / 2 + oLength % 2];
    for (int i = 0; i < (oLength / 2); i++)
    {
        result[i] = originalArray[i] * originalArray[oLength - i - 1];
    }

    if (oLength % 2 != 0)
    {
        result[oLength / 2] = originalArray[oLength / 2];
    }

    return result;
}

int[] originalArray = CreateNewArray(6);
FillArray(originalArray);
PrintArray(originalArray);
Console.Write("-> ");
PrintArray(ProductOfPairsOfNumbersInArray(originalArray));