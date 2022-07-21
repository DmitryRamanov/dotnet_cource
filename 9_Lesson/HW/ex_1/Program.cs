// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5-> "2, 4"
// M = 4; N = 8-> "4, 6, 8"

string GetNaturalNumbersInString(int valueStart, int valueEnd)
{
    if (valueStart > valueEnd)
    {
        return String.Empty;
    }
    if (valueStart == valueEnd)
    {
        return (valueStart % 2 == 0 ? valueStart.ToString() : String.Empty);
    }
    return (valueStart % 2 == 0 ? valueStart.ToString() + ", " : String.Empty)
                + GetNaturalNumbersInString(valueStart + 1, valueEnd);
}

Console.Write("Введите значение M: ");
int valueM = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int valueN = int.Parse(Console.ReadLine());
Console.Write($"M = {valueM}, N = {valueN} -> {GetNaturalNumbersInString(valueM, valueN)}");
if (valueM > valueN)
{
    Console.Write("Число M, начало промежутка, больше числа N, окончания промежутка.");
}
