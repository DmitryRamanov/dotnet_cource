/*
    2. Напишите программу, которая принимает на вход координаты
    двух точек и находит расстояние между ними в 2D пространстве.
*/

void getDistance2D(double aX, double aY, double bX, double bY)
{
    double result = Math.Sqrt(Math.Pow(bX - aX,2) + Math.Pow(bY - aY,2));
    Console.WriteLine($"Расстояние между точками A({aX},{aY}) и B({bX},{bY}) равно {Math.Round(result,2)}");
}

getDistance2D(3, 6, 2, 1); //5.09
getDistance2D(7, -5, 1, 1); //7.21