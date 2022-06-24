using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

                a = 5; b = 7 -> max = 7
                a = 2 b = 10 -> max = 10
                a = -9 b = -3 -> max = -3
            */
            
            Console.Write("Введите число1: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число2: ");
            int value2 = int.Parse(Console.ReadLine());

            if (value1 > value2)
            {
                Console.WriteLine($"Число {value1} больше числа {value2}");
            }
            else
            {
                Console.WriteLine($"Число {value2} больше, либо равно числу {value1}");
            }
        }
    }
}
