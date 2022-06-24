using System;

namespace ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                5 -> 2, 4
                8 -> 2, 4, 6, 8
            */
            
            int value;
            do
            {
                Console.Write("Введите положительное число: ");
                value = int.Parse(Console.ReadLine());
                if (value <= 0)
                {
                    Console.WriteLine("Введено не положительное значение, повторите ввод");
                }
                
            } while (value <= 0);
            
            int index = 2; //индекс для цикла

            if (value == 1)
            {
                Console.WriteLine($"Для числа {value} четных чисел нет");
                return;
            }

            Console.Write($"Для числа {value} есть след. четные числа: ");
            while (index <= value)
            {
                if (index % 2 == 0)
                {
                    Console.Write($"{index}, ");
                }
                index += 2;
            }
        }
    }
}
