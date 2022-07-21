// Задача 2: Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

string GetNaturalNumbersInString(int valueStart, int valueEnd)
{
    string result = string.Empty;
    if (valueStart == valueEnd)
    {
        result += valueStart.ToString();
    }
    else if (valueStart < valueEnd)
    {
        result += valueStart.ToString();
        valueStart++;
        result = result + ", " + GetNaturalNumbersInString(valueStart, valueEnd);
    }
    return result;
}

Console.Write("Введите значение M: ");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {valueM}, N = {valueN} -> {GetNaturalNumbersInString(valueM, valueN)}");
if (valueM > valueN)
{
    Console.Write("Число M, начало промежутка, больше числа N, окончания промежутка.");
}
