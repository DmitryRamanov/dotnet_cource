/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/// <summary>
/// Создаем одномерный массив
/// </summary>
/// <param name="x">Кол-во элементов в массиве</param>
/// <returns></returns>
int[] CreateArray(int x)
{
    return new int[x];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CalcTheNumberOfEvenNumbersInArray(int[] array)
{
    int result = 0;
    foreach(var element in array)
    {
        if (element % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] array = CreateArray(10);
FillArray(array);
PrintArray(array);
Console.Write("-> ");
Console.Write(CalcTheNumberOfEvenNumbersInArray(array));
