using System;

namespace ex_1_star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Модуль числа {value} равен {(value < 0 ? -value : value)}");
        }
    }
}
