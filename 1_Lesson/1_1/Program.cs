using System;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Введите число: ");
           int a = int.Parse(Console.ReadLine());
           Console.WriteLine($"Квадрат числа {a} равен {a*a}");
        }
    }
}
