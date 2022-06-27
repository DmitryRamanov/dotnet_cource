using System;

namespace ex_13
{
    class Program
    {
        static int GetCorrectUserValue()
        {
            int userValue; //значение полученное от пользователя
            bool getCorrectValue = false;

            do
            {
                Console.Write("Введите число: ");
                getCorrectValue = int.TryParse(Console.ReadLine(), out userValue);
                userValue = Math.Abs(userValue); //преобразуем отрицательное число в положительно

                if (getCorrectValue == false)
                {
                    Console.WriteLine("Введено не число! Повторите ввод.");
                }
            } while (getCorrectValue == false);
            
            return userValue;
        }

        static void ShowSpecifiedNumberInValue(in int userValue, uint indexNumber)
        {
            char[] userValueInChar = userValue.ToString().ToCharArray();

            if (indexNumber > userValueInChar.Length)
            {
                Console.WriteLine($"В числе {userValue} нет цифры под номером {indexNumber}");
            }
            else
            {
                Console.WriteLine($"В числе {userValue} цифра под номером {indexNumber} равна {userValueInChar[indexNumber-1]}");
            }
        }
        
        static void Main(string[] args)
        {
            /*
            Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
                        что третьей цифры нет.
            645 -> 5
            78 -> третьей цифры нет
            32679 -> 6
            */
            
            const uint indexNumber = 3; //номер цифры которую надо вывести

            //получаем от пользователя корректное число
            int userValue = GetCorrectUserValue();
            
            //показывает нужную цифру этого числа
            ShowSpecifiedNumberInValue(in userValue, indexNumber);
        }
    }
}
