/*
    2. Напишите программу, которая принимает на вход
        число N и выдаёт произведение чисел от 1 до N.

*/

int GetMultiplyNumber(int value)
{
    int result = 1;

    for (int i = 1; i <= value; i++)
    {
        result *= i;
    }

    return result;
}

Console.WriteLine(GetMultiplyNumber(2));
Console.WriteLine(GetMultiplyNumber(3));
Console.WriteLine(GetMultiplyNumber(4));