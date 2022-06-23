using System;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameDay;
            Console.Write("Введите ноер дня: ");
            int numberDay = int.Parse(Console.ReadLine());
            if (numberDay == 1)
            {
                nameDay = "Понедельник";
            }
            else if (numberDay == 2)
            {
                nameDay = "Вторник";
            }
            else if (numberDay == 3)
            {
                nameDay = "Среда";
            }
            else if (numberDay == 4)
            {
                nameDay = "Четверг";
            }
            else if (numberDay == 5)
            {
                nameDay = "Пятница";
            }
            else if (numberDay == 6)
            {
                nameDay = "Суббота";
            }
            else if (numberDay == 7)
            {
                nameDay = "Воскресение";
            }
            else
            {
                nameDay = "не верный номер дня";
            }
            Console.WriteLine($"День под номером {numberDay} это {nameDay}");
        }
    }
}
