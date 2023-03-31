// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetNumber(string entered)
{
    System.Console.WriteLine($"Enter a number {entered}");
    return int.Parse(System.Console.ReadLine());
}

double x1 = GetNumber("x1");
double x2 = GetNumber("x2");
double x3 = GetNumber("x3");

double y1 = GetNumber("y1");
double y2 = GetNumber("y2");
double y3 = GetNumber("y3");

double Result()
{

    double c = Math.Sqrt(Math.Pow((x1 - y2), 2) + Math.Pow((x2 - y2), 2) + Math.Pow((x3 - y3), 2));

    return Math.Round(c, 2);
}
void Print()
{
    double L = Result();
    System.Console.WriteLine($"Segment length = {L}");
}

Print();









