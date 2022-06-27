using System;

namespace ex_15
{
    class Program
    {
        static sbyte GetCorrectUserValue()
        {
            int userValue; //значение полученное от пользователя
            bool getCorrectValue = false;

            do
            {
                Console.Write("Введите номер дня: ");
                getCorrectValue = int.TryParse(Console.ReadLine(), out userValue);
                
                if (getCorrectValue == false || userValue > 7 || userValue < 1) 
                {
                    Console.WriteLine("Введено не корректное число! Повторите ввод.");
                    getCorrectValue = false; //что бы не выходить из цикла
                }
            } while (getCorrectValue == false);
            
            return (sbyte)userValue;
        }
        
        static void Main(string[] args)
        {
            /*
                Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
                            и проверяет, является ли этот день выходным.
                6 -> да
                7 -> да
                1 -> нет
            */

            //получаем от пользователя корректное число
            sbyte userValue = GetCorrectUserValue();
            Console.WriteLine("Указанные номер дня {0} это {1} день",userValue,((userValue == 6 || userValue == 7)?"ВЫХОДНОЙ":"БУДНИЙ"));
        }
    }
}
