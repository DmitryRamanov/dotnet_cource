// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int CalcPositiveNumberInArray(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if (item > 0)
        {
            result++;
        }
    }
    return result;
}

int[] ConvertStringToIntArray(string value)
{
    string[] strArray = value.Split(','); //разбиваем строку на массив строк, используя разделитель запятую
    int[] result = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        try
        {
            if (strArray[i] == string.Empty)
            {
                result[i] = 0;
            }
            else
            {
                result[i] = int.Parse(strArray[i]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("{0}: Bad Format", strArray[i]);
        }
        catch (OverflowException)
        {
            Console.WriteLine("{0}: Overflow", strArray[i]);
        }

    }
    return result;
}

void PrintArray(Array array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

Console.Write("Введите значения, разделя из запятой и в конце нажмине Enter: ");
string inputValues = string.Empty;
inputValues += Console.ReadLine();
Console.Write(inputValues);
Console.Write($" -> {CalcPositiveNumberInArray(ConvertStringToIntArray(inputValues))}");