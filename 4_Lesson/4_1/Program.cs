// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int GetNumberLenght(int value)
{
    int result = 1;

    for (;value > 0;)
    {
        value = value / 10;
        if (value > 0)
        {
            result = result + 1;
        }
        else
        {
            break;
        }
    }

    return result;
}

Console.WriteLine(GetNumberLenght(456));
Console.WriteLine(GetNumberLenght(78));
Console.WriteLine(GetNumberLenght(89126));
