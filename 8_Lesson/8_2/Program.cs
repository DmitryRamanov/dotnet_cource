// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
            Console.Write($"{array[rowIndex, columnIndex]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixTranspositionForArray2D(int[,] array)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);

    int[,] resultArray = new int[columnsNumber, rowsNumber];

    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            resultArray[columnIndex, rowIndex] = array[rowIndex, columnIndex];
        }
    }

    return resultArray;
}

int[,] array2D = CreateArray2D(3, 6);
FillArray2D(array2D, 1, 9);
PrintArray2D(array2D);
Console.WriteLine();
PrintArray2D(MatrixTranspositionForArray2D(array2D));