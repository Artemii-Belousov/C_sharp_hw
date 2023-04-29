// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetNum("b1");
double k1 = GetNum("k1");
double b2 = GetNum("b2");
double k2 = GetNum("k2");
double Res = Resalt(b1, k1, b2, k2);
double GetNum(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    return double.Parse(System.Console.ReadLine());
}

double Resalt(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    
System.Console.WriteLine($"Пересечение координат {x}:{y}");
return x;
}

