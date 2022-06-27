using System;

namespace _2_4
{
    class Program
    {
        static string CheckValue(in int val)
        {
            if (val % 7 == 0 && val % 23 == 0)
            {
                return "ДА";
            }
            
            return "НЕТ";
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int val = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат проверки: {CheckValue(in val)}");
        }
    }
}
