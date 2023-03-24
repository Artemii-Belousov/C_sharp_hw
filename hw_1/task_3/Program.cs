// Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.Write("Введите число: ");

int i = int.Parse(Console.ReadLine());

if(i % 2 == 0)
{
    Console.Write("Число четное");
}
else {Console.Write("Число не четное");}
