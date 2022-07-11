// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string Conert10Into2(int value)
{
    string result = String.Empty;
    do
    {
        result = (value % 2).ToString() + result;
        value = value / 2;
    } while (value > 0);

    return result;
}

int valueIn10 = 10;
Console.WriteLine($"Числов {valueIn10} в двоичной систем -> {Conert10Into2(valueIn10)}");