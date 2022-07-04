/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double GetPow(double baseValue, double extentValue)
{
    double result = baseValue;

    for (int i = 2; i <= extentValue; i++)
    {
        result *= baseValue;
    }

    return result;
}

Console.WriteLine(GetPow(3,5));
Console.WriteLine(GetPow(2,4));