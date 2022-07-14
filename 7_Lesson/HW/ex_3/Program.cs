// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/// <summary>
/// Создаем пустой 2-х мерный массив, заданной размерности
/// </summary>
/// <param name="numberRows">Кол-во строк в массиве</param>
/// <param name="numberColumns">Кол-во столбцов в массиве</param>
/// <returns>Возвращает ссылку на созданный массив</returns>
int[,] CreateEmptyArray2D(int numberRows, int numberColumns)
{
    return new int[numberRows, numberColumns];
}

/// <summary>
/// Заполняем 2-х мерный массив, рандомными значениями
/// </summary>
/// <param name="array2D">Ссылка на исходный массив</param>
/// <param name="minBorderValue">Начальное значение для диапазона рандоных чисел</param>
/// <param name="maxBorderValue">Конечное значение для диапазона рандоных чисел</param>
void FillArray2D(int[,] array2D, int minBorderValue, int maxBorderValue)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
        {
            array2D[rowIndex, columnIndex] = new Random().Next(minBorderValue, maxBorderValue);
        }
    }
}

/// <summary>
/// Вывод элементов 2-х мерного массива в консоль
/// </summary>
/// <param name="array2D">Ссылка на исходный массив</param>
void PrintArray2D(int[,] array2D)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
        {
            Console.Write($"{array2D[rowIndex, columnIndex],3:D} ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Вывод элементов массива в консоль
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
void PrintArray(double[] array)
{
    for (int rowIndex = 0; rowIndex < array.Length; rowIndex++)
    {
        Console.Write($"{array[rowIndex],5:F2} ");
    }
}

/// <summary>
/// Рассчитать среднее арифметическое для каждого столбца 2-х мерного массива
/// </summary>
/// <param name="array2D">Ссылка на исходный 2-х мерный массив</param>
/// <returns>Одномерный массив с расчитанными значениями</returns>
double[] GetArithmeticMeanOfEachColumn(int[,] array2D)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве
    double[] result = new double[numberColumns]; //создаем одномерный массив для результатов

    for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
    {
        double sumOfAllColumnElements = 0.0;
        for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
        {
            sumOfAllColumnElements += array2D[rowIndex, columnIndex];
        }
        result[columnIndex] = sumOfAllColumnElements / numberRows;
    }
    return result;
}

int[,] array2D = CreateEmptyArray2D(5, 8); //создаем пустой 2-х мерный массив

FillArray2D(array2D, 1, 9); //заполняем рандомными значениями
PrintArray2D(array2D); //выводим массив в консоль
double[] array = GetArithmeticMeanOfEachColumn(array2D); //считаем среднее арифметическое каждого столбца
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(array); //выводим массив в консоль