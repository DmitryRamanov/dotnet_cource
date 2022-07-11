// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/// <summary>
/// Получаем от пользователя целое число
/// </summary>
/// <param name="valueName">Название переменной</param>
/// <returns></returns>
int InputValue(string valueName)
{
    int result;
    bool success = false;
    Console.Write($"Введите значение {valueName}: ");
    do
    {
        success = int.TryParse(Console.ReadLine(), out result);
        if (!success)
        {
            Console.WriteLine($"Введенное значение не является числом, повторите ввод!");
            Console.Write($"Введите значение {valueName}: ");
        }
    } while (!success);

    return result;
}

/// <summary>
/// Расчитываем координаты точки пересечения двух прямых
/// </summary>
/// <param name="b1"></param>
/// <param name="k1"></param>
/// <param name="b2"></param>
/// <param name="k2"></param>
/// <returns></returns>
string GetCoordinates(int b1, int k1, int b2, int k2)
{
    double x = 0, y = 0;

    x = Math.Round((double)(b2 - b1) / (double)(k1 - k2), 1);
    y = Math.Round(k2 * x + b2, 2);

    return string.Concat("(", x, "; ", y, ")");
}

int b1 = InputValue("b1");
int k1 = InputValue("k1");
int b2 = InputValue("b2");
int k2 = InputValue("k2");

string strFormat = $"{nameof(b1)} = {b1}, {nameof(k1)} = {k1}, {nameof(b2)} = {b2}, {nameof(k2)} = {k2} -> {GetCoordinates(b1, k1, b2, k2)}";
Console.WriteLine(strFormat);