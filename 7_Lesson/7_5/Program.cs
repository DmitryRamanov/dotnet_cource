// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

void CheckValueInArray(int[,] array2D, int valueForChecking, out int coordX, out int coordY)
{
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);
    coordX = coordY = -1;

    for (int row_index = 0; row_index < rowsNumber; row_index++)
    {
        for (int column_index = 0; column_index < columnsNumber; column_index++)
        {
            if (valueForChecking == array2D[row_index, column_index])
            {
                coordX = column_index;
                coordY = row_index;
                break;
            }
        }
    }
}

int[,] array2D = CreateEmpty2DArray(3, 4);
int valueForChecking = 3;
int coordX, coordY = -1;
Fill2DArray(array2D, 1, 9);
Print2DArray(array2D);
CheckValueInArray(array2D, valueForChecking, out coordX, out coordY);
Console.WriteLine($"Введенный элемент {valueForChecking}, результат: [{coordY + 1}, {coordX + 1}]");
