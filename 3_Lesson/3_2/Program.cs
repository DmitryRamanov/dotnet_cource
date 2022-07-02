void CoordinateRange(int quarterNumer)
{
    string result = string.Empty;
    if (quarterNumer == 1)
    {
        result = "x > 0 & y > 0";
    }
    else if (quarterNumer == 2)
    {
        result = "x < 0 & y > 0";
    }
    else if (quarterNumer == 3)
    {
        result = "x < 0 & y < 0";
    }
    else if (quarterNumer == 4)
    {
        result = "x > 0 & y < 0";
    }
    else
    {
        result = "ВЫХОД ЗА ПРЕДЕЛЫ ДОПУСТИМЫХ ЗНАЧЕНИЙ ДЛЯ ОПРЕДЕЛЕНИЯ ЧЕТВЕРТИ";
    }
    Console.WriteLine($"Для черверти {quarterNumer} соот-ют след. кординаты: {result}");
}

CoordinateRange(0);
CoordinateRange(4);
CoordinateRange(3);
CoordinateRange(1);
CoordinateRange(2);
CoordinateRange(10);
CoordinateRange(-10);