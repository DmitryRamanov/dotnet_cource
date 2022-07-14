// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/// <summary>
/// Создаем пустой 2-х мерный массив, заданной размерности
/// </summary>
/// <param name="numberRows">Кол-во строк в массиве</param>
/// <param name="numberColumns">Кол-во столбцов в массиве</param>
/// <returns></returns>
double[,] CreateEmptyArray2D(int numberRows, int numberColumns)
{
    return new double[numberRows, numberColumns];
}

/// <summary>
/// Заполняем 2-х мерный массив, рандомными значениями
/// </summary>
/// <param name="array2D">Ссылка на исходный массив</param>
void FillArray2D(double[,] array2D)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
        {
            array2D[rowIndex, columnIndex] = new Random().NextDouble() * 100;
        }
    }
}

/// <summary>
/// Вывод элементов 2-х мерного массива в консоль
/// </summary>
/// <param name="array2D">Ссылка на исходный массив</param>
void PrintArray2D(double[,] array2D)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
        {
            Console.Write($"{array2D[rowIndex, columnIndex],7:F2} ");
        }
        Console.WriteLine();
    }
}

double[,] array2D = CreateEmptyArray2D(3, 4); //создаем пустой 2-х мерный массив
FillArray2D(array2D); //заполняем рандомными значениями
PrintArray2D(array2D); //выводим массив в консоль