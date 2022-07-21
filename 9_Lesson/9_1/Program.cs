// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string GetNaturalNumbersInString(int value)
{
    string result = string.Empty;
    if (value == 1)
    {
        result = "1" + result;
    }
    else
    {
        result = result + value.ToString();
        value--;
        result = GetNaturalNumbersInString(value) + ", " + result;
    }
    return result;
}

Console.Write("Введите значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N = {valueN} -> {GetNaturalNumbersInString(valueN)}");