using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
                2, 3, 7 -> 7
                44 5 78 -> 78
                22 3 9 -> 22
            */
            
            Console.Write("Введите число1: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число2: ");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число3: ");
            int value3 = int.Parse(Console.ReadLine());

            if ((value1 >= value2) && (value1 >= value3))
            {
                Console.WriteLine($"Число {value1} больше, либо равно числам {value2} и {value3}");
            }
            else if ((value2 >= value1) && (value2 >= value3))
            {
                Console.WriteLine($"Число {value2} больше, либо равно числам {value1} и {value3}");
            }
            else
            {
                Console.WriteLine($"Число {value3} больше, либо равно числам {value1} и {value2}");
            }
        }
    }
}
