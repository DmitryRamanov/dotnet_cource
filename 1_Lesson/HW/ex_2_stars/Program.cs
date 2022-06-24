using System;

namespace ex_2_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            decimal value = decimal.Parse(Console.ReadLine());
            decimal reverseValue = Math.Round(1 / value,3);
            Console.WriteLine($"Обратное значение для числа {value} равно {reverseValue}");
        }
    }
}
