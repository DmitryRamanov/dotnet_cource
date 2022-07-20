// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,]? GetArray2DMultiplication(int[,] firstArray2D, int[,] secondArray2D)
{
    int rowsNumber1 = firstArray2D.GetLength(0);
    int columnsNumber1 = firstArray2D.GetLength(1);
    int rowsNumber2 = secondArray2D.GetLength(0);
    int columnsNumber2 = secondArray2D.GetLength(1);
    if (columnsNumber1 != rowsNumber2)
    {
        return null;
    }

    int[,] result = new int[rowsNumber1, columnsNumber2];
    for (int rowIndex1 = 0; rowIndex1 < rowsNumber1; rowIndex1++)
    {
        for (int columnIndex2 = 0; columnIndex2 < columnsNumber2; columnIndex2++)
        {
            int columnsSum = 0;
            for (int index = 0; index < columnsNumber1; index++)
            {
                columnsSum += firstArray2D[rowIndex1, index] * secondArray2D[index, columnIndex2]; ;
            }
            result[rowIndex1, columnIndex2] = columnsSum;
        }
    }
    return result;
}

int rowsNumber1 = 3, columnsNumber1 = 4;
int[,] firstArray2D = CreateArray2D(rowsNumber1, columnsNumber1);
FillArray2D(firstArray2D, 0, 9);

int rowsNumber2 = 4, columnsNumber2 = 2;
int[,] secondArray2D = CreateArray2D(rowsNumber2, columnsNumber2);
FillArray2D(secondArray2D, 0, 9);

Console.WriteLine("Исходные массивы:");
PrintArray2D(firstArray2D);
Console.WriteLine("X");
PrintArray2D(secondArray2D);

int[,]? resultArray2D = GetArray2DMultiplication(firstArray2D, secondArray2D);
Console.WriteLine("--------------------");
if (resultArray2D == null)
{
    Console.WriteLine("Размерность массивов не позволяет сделать их умножение");
}
else
{
    PrintArray2D(resultArray2D);
}
