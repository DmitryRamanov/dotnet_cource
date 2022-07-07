/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0
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

/// <summary>
/// Заполнение массива случайными числами
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
/// <param name="minBorder">Минимальное число, нижняя граница диапазона случаных чисел</param>
/// <param name="maxBorder">Максимальное число, верняя граница диапазона случаных чисел</param>
void FillArray(int[] array, int minBorder, int maxBorder)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minBorder, maxBorder);
    }
}

/// <summary>
/// Вывод содержимого массива в Console
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

/// <summary>
/// Считаем сумму элементов, стоящих на нечётных позициях массива.
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
/// <returns></returns>
int CalcSumOfArrayElementsInOddPositions(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 != 0)
        {
            result += array[i];
        }
    }
    return result;
}

int[] array = CreateArray(5);
FillArray(array, -10, 100);
PrintArray(array);
Console.Write("-> ");
Console.Write(CalcSumOfArrayElementsInOddPositions(array));