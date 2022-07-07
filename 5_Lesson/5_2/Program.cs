/*
Напишите программу замена элементов массива:
положительные элементы замените на соответствующие
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] CreateNewArray(int arrayLength)
{
    return new int[arrayLength];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ChangePositiveNumbersOnNegativeInArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = CreateNewArray(12);
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangePositiveNumbersOnNegativeInArray(array);
PrintArray(array);