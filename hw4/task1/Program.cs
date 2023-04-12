// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetNumber()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(System.Console.ReadLine());
}
int number = GetNumber();
int dagree = GetNumber();

int Solution()
{
    int resalt = 1;

    for (int i = 0; i < dagree; i++)
    {
        resalt *= number;
    }
    return resalt;
}


int res = Solution();

System.Console.WriteLine(res);