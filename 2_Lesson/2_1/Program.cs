using System;

namespace _2_1
{
    class Program
    {
        static int GetLastSimbol(int value)
        {
            return (value % 10);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Последний символ числа {value} равен {GetLastSimbol(value)}");
        }
    }
}
