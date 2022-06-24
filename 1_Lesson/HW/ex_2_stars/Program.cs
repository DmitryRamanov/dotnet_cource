using System;

namespace ex_2_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Напишите программу, которая на вход принимает значение, а
                на выходе показывает обратное значение.
                1 -> 1
                2 -> 0.5
                0.25 -> 4
            */
            
            Console.Write("Введите число: ");
            decimal value = decimal.Parse(Console.ReadLine());
            decimal reverseValue = Math.Round(1 / value,3);
            Console.WriteLine($"Обратное значение для числа {value} равно {reverseValue}");
        }
    }
}
