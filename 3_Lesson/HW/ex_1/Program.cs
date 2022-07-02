/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool checkingIfNumberIsPalindrome(long number)
{
    bool result = false;
    if (number > 0)
    {
        string numberStr = number.ToString();
        int strLength = numberStr.Length;
        for (int i = 0; i < strLength / 2; i++)
        {
            if (numberStr[i] != numberStr[strLength - i - 1])
            {
                result = false;
                break;
            }
            else
            {
                result = true;
            }
        }
    }

    return result;
}

long number = 14212;
Console.WriteLine($"{number} -> {checkingIfNumberIsPalindrome(number)}");
number = 23432;
Console.WriteLine($"{number} -> {checkingIfNumberIsPalindrome(number)}");
number = 12821;
Console.WriteLine($"{number} -> {checkingIfNumberIsPalindrome(number)}");
number = 983389;
Console.WriteLine($"{number} -> {checkingIfNumberIsPalindrome(number)}");
number = 2222222222;
Console.WriteLine($"{number} -> {checkingIfNumberIsPalindrome(number)}");
number = 19311113231111391;
Console.WriteLine($"{number} -> {checkingIfNumberIsPalindrome(number)}");
