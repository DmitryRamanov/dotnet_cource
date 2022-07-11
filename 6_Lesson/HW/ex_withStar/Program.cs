// Задача 4: Напишите программу, которая будет создавать копию 2-х мерного заданного массива 
//из вещественных чисел с помощью поэлементного копирования.

/// <summary>
/// Создание пустого 2-х мерного массива
/// </summary>
/// <param name="rows">Кол-во строк в массиве</param>
/// <param name="columns">Кол-во столбцов в массиве</param>
/// <returns></returns>
double[,] Create2DEmptyArray(int rows, int columns)
{
    return new double[rows, columns];
}

/// <summary>
/// Заполнение 2-х мерного массива, рандомными значениями
/// </summary>
/// <param name="array">Ссылка на массив</param>
void Fill2DArray(double[,] array)
{
    int numberRows = array.GetLength(0);
    int numberColumns = array.GetLength(1);
    for (int row = 0; row < numberRows; row++)
    {
        for (int column = 0; column < numberColumns; column++)
        {
            array[row, column] = Math.Round((new Random().NextDouble()) * 100, 2);
        }
    }
}

/// <summary>
/// Выводим в консоль содержимое 2-х мерного массива
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
void Print2DArray(double[,] array)
{
    int numberRows = array.GetLength(0);
    int numberColumns = array.GetLength(1);
    for (int row = 0; row < numberRows; row++)
    {
        for (int column = 0; column < numberColumns; column++)
        {
            Console.Write($"{array[row, column],5:F2}  ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Копируем элементы исходного 2-х мерного массива в новый 2-х мерный массив
/// </summary>
/// <param name="array">Ссылка на исходный массив</param>
/// <returns></returns>
double[,] Copy2DArray(double[,] array)
{
    int numberRows = array.GetLength(0);
    int numberColumns = array.GetLength(1);
    double[,] result = new double[numberRows, numberColumns];

    for (int row = 0; row < numberRows; row++)
    {
        for (int column = 0; column < numberColumns; column++)
        {
            result[row, column] = array[row, column];
        }
    }

    return result;
}

double[,] array = Create2DEmptyArray(4, 6); //создание исходного пустого 2-х мерного массива
Fill2DArray(array); //заполнение 2-х мерного массива
Print2DArray(array); //вывод в консоль содержимого исходного 2-х мерного массива
double[,] copyArray = Copy2DArray(array); //создаем новый 2-х мерный массив и копируем в него содержимое исходного массива
Console.WriteLine();
Print2DArray(copyArray); //вывод в консоль содержимое копии