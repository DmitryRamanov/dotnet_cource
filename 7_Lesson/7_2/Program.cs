// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m + n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateEmpty2DArray(int rowsNumber, int columnsNumber)
{
    return new int[rowsNumber, columnsNumber];
}

void Fill2DArray(int[,] array2D)
{
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);

    for (int row_index = 0; row_index < rowsNumber; row_index++)
    {
        for (int column_index = 0; column_index < columnsNumber; column_index++)
        {
            array2D[row_index, column_index] = row_index + column_index;
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
            Console.Write($"{array2D[row_index, column_index],2:D} ");
        }
        Console.WriteLine();
    }
}

int[,] array2D = CreateEmpty2DArray(3, 4);
Fill2DArray(array2D);
Print2DArray(array2D);