// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите число M");
int n = InputInt("Введите число N");
System.Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalNum(m, n)}");

int CountNaturalNum(int m, int n)
{
    if(m == n) return n;
    return n + CountNaturalNum(m, n - 1);
}

int InputInt(string input)
{
    System.Console.WriteLine(input);
    return int.Parse(Console.ReadLine());
}

