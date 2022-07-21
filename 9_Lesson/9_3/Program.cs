// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int GetSumNumbers(int value)
{
    if (value == 0)
    {
        return 0;
    }
    return GetSumNumbers(value / 10) + value % 10;
}

Console.Write("Введите значение N: ");
int valueN = int.Parse(Console.ReadLine());
Console.WriteLine($"N = {valueN} -> {GetSumNumbers(valueN)}");