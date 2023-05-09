// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = InputInt("Введите положительное число");
int m = 1;


if (n < 1)
{
    System.Console.WriteLine("Ввели не положительное число.");
}
System.Console.WriteLine(NaturalNamber(n, m));

int NaturalNamber(int n, int m)
{
    if (n == m) return n;

    else System.Console.Write($"{NaturalNamber(n, m + 1)}, ");

    return m;
}


int InputInt(string input)
{
    System.Console.WriteLine(input);
    return int.Parse(Console.ReadLine());
}


