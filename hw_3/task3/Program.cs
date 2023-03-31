
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Number()
{
    System.Console.WriteLine("Entered a number: ");
    return int.Parse(System.Console.ReadLine());
}


void Solution()
{
    int num = Number();
    for (int i = 1; i <= num; i++)
    {
        // int y = Math.Pow(i, 3);
        System.Console.WriteLine(Math.Pow(i, 3));
    }
}
Solution();









