// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 3 10 7 3
// 1 5 9 3
// 8 4 7 0
// 7 1 9 3

// В итоге получается вот такой массив:
// 10 7 3 3
// 9 5 3 1
// 8 7 4 0
// 9 7 3 1

int[,] CreateArray2D(int rowsNumber, int columnsNumber)
{
    return new int[rowsNumber, columnsNumber];
}

void FillArray2D(int[,] array, int startValue, int endValue)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);

    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            array[rowIndex, columnIndex] = new Random().Next(startValue, endValue);
        }
    }
}

void PrintArray2D(int[,] array)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);

    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            Console.Write($"{array[rowIndex, columnIndex],3:d} ");
        }
        Console.WriteLine();
    }
}

void SortRowsArray2DByDesc(int[,] array)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);

    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndexExternal = 0; columnIndexExternal < columnsNumber; columnIndexExternal++)
        {
            int maxValue = array[rowIndex, columnIndexExternal];
            int indexForMaxValue = columnIndexExternal;
            for (int columnIndexInternal = columnIndexExternal; columnIndexInternal < columnsNumber; columnIndexInternal++)
            {
                if (maxValue < array[rowIndex, columnIndexInternal])
                {
                    maxValue = array[rowIndex, columnIndexInternal];
                    indexForMaxValue = columnIndexInternal;
                }
            }
            array[rowIndex, indexForMaxValue] = array[rowIndex, columnIndexExternal];
            array[rowIndex, columnIndexExternal] = maxValue;
        }
    }
}

int[,] array2D = CreateArray2D(4, 6);
Console.WriteLine("Исходный массив:");
FillArray2D(array2D, 0, 20);
PrintArray2D(array2D);
SortRowsArray2DByDesc(array2D);
Console.WriteLine();
Console.WriteLine("В итоге получили массив:");
PrintArray2D(array2D);