// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[,] ModifyArray2D(int[,] array, out int valueOfMinElemetInArray)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);
    int[,] result = new int[rowsNumber - 1, columnsNumber - 1];

    valueOfMinElemetInArray = array[0, 0];
    int minValueRowIndex = 0, minValueColumnIndex = 0;
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            if (valueOfMinElemetInArray > array[rowIndex, columnIndex])
            {
                valueOfMinElemetInArray = array[rowIndex, columnIndex];
                minValueRowIndex = rowIndex;
                minValueColumnIndex = columnIndex;
            }
        }
    }

    for (int rowIndex = 0, rowIndex1 = 0; rowIndex < rowsNumber; rowIndex++, rowIndex1++)
    {
        if (minValueRowIndex == rowIndex)
        {
            rowIndex1--;
            continue;
        }

        for (int columnIndex = 0, columnIndex1 = 0; columnIndex < columnsNumber; columnIndex++, columnIndex1++)
        {
            if (minValueColumnIndex == columnIndex)
            {
                columnIndex1--;
                continue;
            }
            result[rowIndex1, columnIndex1] = array[rowIndex, columnIndex];
        }
    }

    return result;
}

int rowsNumber = 6, columnsNumber = 6;
int[,] array2D = CreateArray2D(rowsNumber, columnsNumber);
FillArray2D(array2D, 1, 99);

Console.WriteLine("Исходный массив:");
PrintArray2D(array2D);

int valueOfMinElemetInArray;
int[,] resultArray2D = ModifyArray2D(array2D, out valueOfMinElemetInArray);

Console.WriteLine();
Console.WriteLine($"Наименьший элемент {valueOfMinElemetInArray}, на выходе получим следующий массив:");
PrintArray2D(resultArray2D);