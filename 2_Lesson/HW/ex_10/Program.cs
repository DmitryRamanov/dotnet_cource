using System;

namespace ex_10
{
    class Program
    {
        static string GetCorrectValue()
        {
            int userValue; //значение полученное от пользователя
            bool getCorrectValue = false;

            do
            {
                Console.Write("Введите число: ");
                getCorrectValue = int.TryParse(Console.ReadLine(), out userValue);
                userValue = Math.Abs(userValue);

                //userValue = Math.Abs(int.Parse(Console.ReadLine()));
                if (getCorrectValue == false | userValue > 999 | userValue <= 99)
                {
                    Console.WriteLine("Введено не 3-х значное число! Повторите ввод.");
                    getCorrectValue = false; //что бы не выйти из цикла
                }
            } while (getCorrectValue == false);
            
            return userValue.ToString();
        }

        static void Main(string[] args)
        {
            /*
            Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
                        показывает вторую цифру этого числа.
            456 -> 5
            782 -> 8
            918 -> 1
            */
           
            //получаем от пользователя корректное 3-х значное число
            char[] userValueInChar = GetCorrectValue().ToCharArray();
            
            //показывает вторую цифру этого числа
            Console.WriteLine(userValueInChar[1]);
        }
    }
}