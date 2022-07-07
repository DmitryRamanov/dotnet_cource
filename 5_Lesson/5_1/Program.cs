/*
Задача 1: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна -20.
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,9);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetSumOfPositiveNumbersArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result += array[i];
        }
    }
    return result;
}

int GetSumOfNegativeNumbersArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            result += array[i];
        }
    }
    return result;
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительный чисел массива = {GetSumOfPositiveNumbersArray(array)}");
Console.WriteLine($"Сумма положительный чисел массива = {GetSumOfNegativeNumbersArray(array)}");