// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15-> 120
// M = 4; N = 8-> 30

int GetAmountNaturalNumbers(int valueStart, int valueEnd)
{
    if (valueStart > valueEnd)
    {
        return 0;
    }
    if (valueStart == valueEnd)
    {
        return valueEnd;
    }
    return valueStart + GetAmountNaturalNumbers(valueStart + 1, valueEnd);
}

Console.Write("Введите значение M: ");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {valueM}, N = {valueN} -> {GetAmountNaturalNumbers(valueM, valueN)}");
if (valueM > valueN)
{
    Console.Write("Число M, начало промежутка, больше числа N, окончания промежутка.");
}