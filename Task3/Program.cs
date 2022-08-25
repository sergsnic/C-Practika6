// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Tuple<double, double> PointIntersection(double numberB1, double numberK1, double numberB2, double numberK2)
{
    double numberX = (numberB2 - numberB1) / (numberK1 - numberK2);
    double numberY = numberK1 * numberX + numberB1;
    return Tuple.Create(numberX, numberY);
}

Console.WriteLine("Введите параметры уравнений y = k1 * x + b1, y = k2 * x + b2");
System.Console.Write("Введите число b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка пересечения отрезков: {PointIntersection(numberB1, numberK1, numberB2, numberK2)}");