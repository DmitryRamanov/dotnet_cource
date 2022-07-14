// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

int[,] CreateEmpty2DArray(int rowsNumber, int columnsNumber)
{
    return new int[rowsNumber, columnsNumber];
}

void Fill2DArray(int[,] array2D, int minBorderForRandom, int maxBorderForRandom)
{
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);

    for (int row_index = 0; row_index < rowsNumber; row_index++)
    {
        for (int column_index = 0; column_index < columnsNumber; column_index++)
        {
            array2D[row_index, column_index] = new Random().Next(minBorderForRandom, maxBorderForRandom);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);

    for (int row_index = 0; row_index < rowsNumber; row_index++)
    {
        for (int column_index = 0; column_index < columnsNumber; column_index++)
        {
            Console.Write($"{array2D[row_index, column_index],4:D} ");
        }
        Console.WriteLine();
    }
}

int GetSumElementsForMainDiagonal(int[,] array2D)
{
    int arrayLength, result = 0;
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);
    arrayLength = (rowsNumber > columnsNumber ? columnsNumber : rowsNumber);
    for (int i = 0; i < arrayLength; i++)
    {
        result += array2D[i, i];
    }

    return result;
}

int[,] array2D = CreateEmpty2DArray(4, 5);
Fill2DArray(array2D, 1, 9);
Print2DArray(array2D);
Console.WriteLine($"Сумма элементов главной диагонали: {GetSumElementsForMainDiagonal(array2D)}");
