/*
    Напишите программу, которая принимает на вход число (N)
    и выдаёт таблицу квадратов чисел от 1 до N.
*/

void numberSquares(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{Math.Pow(i,2)}, ");
    }
}

numberSquares(5); //1,4,9,16,25
Console.WriteLine();
numberSquares(2); //1,4