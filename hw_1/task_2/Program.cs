// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if(a > b && a > c)
{
    Console.Write("Максимальное число а равное: " + a);
}
else if(b > a && b > c)
{
    Console.Write("Максимальное число b равное: " + b);
}
else if(c > a && c > b)
{
    Console.Write("Максимальное число c равное: " + c);
}


