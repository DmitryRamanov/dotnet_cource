// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetArray2DRowNumberWithMinSumOfElements(int[,] array)
{
    int result = 0, minSumAmongRows = 0;
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);

    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        int sumOfCurrentRow = 0;
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            sumOfCurrentRow += array[rowIndex, columnIndex];
        }
        if (minSumAmongRows > sumOfCurrentRow || minSumAmongRows == 0)
        {
            minSumAmongRows = sumOfCurrentRow;
            result = rowIndex;
        }
    }
    return result + 1;
}

int[,] array2D = CreateArray2D(4, 5);
Console.WriteLine("Исходный массив:");
FillArray2D(array2D, 0, 10);
PrintArray2D(array2D);
Console.WriteLine($"-> {GetArray2DRowNumberWithMinSumOfElements(array2D)}");