/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSum(int value)
{
    int result = 0;
    bool isSignMinus = false; //если у нас число отрицательное

    if (value < 0)
    {
        isSignMinus = true;
        value = Math.Abs(value);
    }

    for (; value > 0; value /= 10)
    {
        if (value > 10)
        {
            result += value % 10;
        }
        else
        {
            result += value;
            break;
        }
    }
    
    if (isSignMinus == true)
    {
        result = -result;
    }

    return result;
}

Console.WriteLine(GetSum(452));
Console.WriteLine(GetSum(82));
Console.WriteLine(GetSum(9012));