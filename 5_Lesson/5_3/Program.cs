/*
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int[] CreateNewArray(int arrayLength)
{
    return new int[arrayLength];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool CheckNumberInArray(int[] array, int value)
{
    bool result = false;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            result = true;
            break;
        }
    }

    return result;
}

int valueForSearch = 15;
int[] array = CreateNewArray(12);
FillArray(array);
Console.Write($"{valueForSearch}; [");
PrintArray(array);
Console.Write($"] -> {CheckNumberInArray(array,valueForSearch)}");
