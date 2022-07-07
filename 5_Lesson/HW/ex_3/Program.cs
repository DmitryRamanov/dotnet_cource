/*
Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76
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
/// Считаем разницу между максимальным и минимальным элементов массива
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
/// <returns></returns>
int CalcDifferenceBetweenTheMaxAndMinArrayElements(int[] array)
{
    int maxValue = 0;
    int minValue = maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minValue > array[i])
        {
            minValue = array[i];
        }

        if (maxValue < array[i])
        {
            maxValue = array[i];
        }
    }
    return (maxValue - minValue);
}

int[] array = CreateArray(5);
FillArray(array, 1, 100);
PrintArray(array);
Console.Write("-> ");
Console.Write(CalcDifferenceBetweenTheMaxAndMinArrayElements(array));