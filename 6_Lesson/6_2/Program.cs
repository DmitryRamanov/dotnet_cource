// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool CheckTriangle(int valueA, int valueB, int valueC)
{
    if (valueA > valueB + valueC)
    {
        return false;
    }
    if (valueB > valueA + valueC)
    {
        return false;
    }
    if (valueC > valueB + valueA)
    {
        return false;
    }
    return true;
}

int valueA = 9;
int valueB = 3;
int valueC = 5;

Console.WriteLine($"Может-ли существовать треугольник со сторонами ({valueA},{valueB},{valueC}) -> {CheckTriangle(valueA, valueB, valueC)}");