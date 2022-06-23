using System;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result; //логический результат сравнения
            
            Console.Write("Введите число 1: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2: ");
            int value2 = int.Parse(Console.ReadLine());
            if (value1 * value1 == value2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            //x < y ? (x+y) : (x-y)
            Console.WriteLine($"Квадрат числа {value1}{(result?"":" не")} равен числу {value2}");
        }
    }
}
