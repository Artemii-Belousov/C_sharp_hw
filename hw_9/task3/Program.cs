// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите два пложительных числа: M и N");

int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");


int InputNum(string input)
{
    System.Console.WriteLine(input);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;

    if(m > 0 && n == 0) return Akkerman(m - 1, 1);

    else return Akkerman(m - 1, Akkerman(m, n - 1));
}


