// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void Main()
{
    Print();
}

void Print()
{
    int dayOfWeek = GetDayOfWeek();

    // Этот код работает.
    if (dayOfWeek == 6 || dayOfWeek == 7)
    {
        System.Console.WriteLine("Выходной");
    }

    // bool weekend = Weekend(dayOfWeek);
}

int GetNumder()
{
    System.Console.WriteLine("Enter a number: ");
    return int.Parse(System.Console.ReadLine());
}
// bool Weekend(bool u)
// {
//     int dayOfWeek = GetDayOfWeek();
//     if (dayOfWeek == 6 || dayOfWeek == 7)
//     {
//         System.Console.WriteLine("Выходной");
//     }
//     return u;
// }

int GetDayOfWeek()
{
    int num = GetNumder();
    switch (num)
    {
        case 1: Console.WriteLine("Понедельник"); break;
        case 2: Console.WriteLine("Вторник"); break;
        case 3: Console.WriteLine("Среда"); break;
        case 4: Console.WriteLine("Четверг"); break;
        case 5: Console.WriteLine("Пятница"); break;
        case 6: Console.WriteLine("Суббота"); break;
        case 7: Console.WriteLine("Воскресенье"); break;
        default: Console.WriteLine("ERROR"); break;
    }

    return num;

}

Main();