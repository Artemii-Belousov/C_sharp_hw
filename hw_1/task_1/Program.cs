// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a > b )
{
    Console.Write("Число а " + "бльше чем число b");
}
else
{
    Console.Write("Число b " + " бльше чем число a");
}
