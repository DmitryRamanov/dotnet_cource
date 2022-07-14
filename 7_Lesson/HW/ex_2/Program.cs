// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

/// <summary>
/// Создаем пустой 2-х мерный массив, заданной размерности
/// </summary>
/// <param name="numberRows">Кол-во строк в массиве</param>
/// <param name="numberColumns">Кол-во столбцов в массиве</param>
/// <returns>Возвращает ссылку на созданный массив</returns>
int[,] CreateEmptyArray2D(int numberRows, int numberColumns)
{
    return new int[numberRows, numberColumns];
}

/// <summary>
/// Заполняем 2-х мерный массив, рандомными значениями
/// </summary>
/// <param name="array2D">Ссылка на исходный массив</param>
/// <param name="minBorderValue">Начальное значение для диапазона рандоных чисел</param>
/// <param name="maxBorderValue">Конечное значение для диапазона рандоных чисел</param>
void FillArray2D(int[,] array2D, int minBorderValue, int maxBorderValue)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
        {
            array2D[rowIndex, columnIndex] = new Random().Next(minBorderValue, maxBorderValue);
        }
    }
}

/// <summary>
/// Вывод элементов 2-х мерного массива в консоль
/// </summary>
/// <param name="array2D">Ссылка на исходный массив</param>
void PrintArray2D(int[,] array2D)
{
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    for (int rowIndex = 0; rowIndex < numberRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < numberColumns; columnIndex++)
        {
            Console.Write($"{array2D[rowIndex, columnIndex],3:D} ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Получаем значение из массива, по заданной позиции
/// </summary>
/// <param name="array2D">Ссылка на 2-х мерный массив</param>
/// <param name="rowNumber">Номер строки позиции</param>
/// <param name="columnNumber">Номер столбца позиции</param>
/// <returns>Возвращает найденное значение из массива или null, если значение не найдено</returns>
int? GetValueInArray(int[,] array2D, int rowNumber, int columnNumber)
{
    int? result = null;
    int numberRows = array2D.GetLength(0); //получаем кол-во строк в массиве
    int numberColumns = array2D.GetLength(1); //получаем кол-во столбцов в массиве

    if (rowNumber <= numberRows && columnNumber <= numberColumns)
    {
        result = array2D[rowNumber - 1, columnNumber - 1];
    }

    return result;
}

/// <summary>
/// Получаем от пользователя номер позиции, для заданного измерения массива
/// </summary>
/// <param name="coordinateName">Название измерения массива</param>
/// <returns>Возращает введенное пользователем целое число</returns>
int GetСoordinateFromUser(string coordinateName)
{
    int result;
    bool success = true;
    do
    {
        Console.Write($"Введите номер {coordinateName}: ");
        success = int.TryParse(Console.ReadLine(), out result);
        if (!success)
        {
            Console.WriteLine("Введенное значение не является целым числом. Повторите ввод значения!");
        }
    } while (!success);
    return result;
}

int[,] array2D = CreateEmptyArray2D(3, 4); //создаем пустой 2-х мерный массив

FillArray2D(array2D, 1, 9); //заполняем рандомными значениями
PrintArray2D(array2D); //выводим массив в консоль

int rowNumber, columnNumber;
rowNumber = GetСoordinateFromUser("строки"); //получаем позицию по строкам
columnNumber = GetСoordinateFromUser("столбца"); //получаем позицию по столбцам

//получаем значение из массива по его позиции
string? valueInArray = GetValueInArray(array2D, rowNumber, columnNumber).ToString();

Console.Write($"[{rowNumber},{columnNumber}] -> ");
if (valueInArray == String.Empty || valueInArray == null)
{
    valueInArray = "такого числа в массиве нет";
}
Console.Write(valueInArray);