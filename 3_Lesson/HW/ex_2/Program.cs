/*
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double getDistance3D(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double result = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2));
    return Math.Round(result, 2);
}

Console.WriteLine($"Расстояние между точками A(3,6,8) и B(2,1,-7) -> {getDistance3D(3, 6, 8, 2, 1, -7)}"); //15.84
Console.WriteLine($"Расстояние между точками A(3,6,8) и B(2,1,-7) -> {getDistance3D(7, -5, 0, 1, -1, 9)}"); //11.53