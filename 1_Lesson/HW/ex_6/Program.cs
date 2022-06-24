using System;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
                (делится ли оно на два без остатка).
                4 -> да
                -3 -> нет
                7 -> нет
            */
            
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine($"Число {value} четное");
            }
            else
            {
                Console.WriteLine($"Число {value} не четное");
            }
        }
    }
}
