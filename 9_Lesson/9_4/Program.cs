// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

int GetTheExponentOfANumber(int valueA, int valueB)
{
    if (valueB == 0)
    {
        return 1;
    }
    return GetTheExponentOfANumber(valueA, valueB - 1) * valueA;
}

Console.Write("Введите значение A: ");
int valueA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B: ");
int valueB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A = {valueA}, B = {valueB} -> {GetTheExponentOfANumber(valueA, valueB)}");