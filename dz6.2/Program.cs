// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите значение В1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение К1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение В2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение К2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


void PointCoordinates(double B1, double K1, double B2, double K2)
{
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 2);
    double y = x;
    Console.Write($"({x}, {y})");
}


PointCoordinates(b1, k1, b2, k2);