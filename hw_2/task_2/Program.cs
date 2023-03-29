
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Main()
{
    Print();
}

void Print()
{

    int sum = GetResult();
    System.Console.WriteLine("Result: " + sum);
}

int GetNumder()
{
    System.Console.WriteLine("Enter a nunber: ");
    return int.Parse(System.Console.ReadLine());
}


int GetResult()
{
    int num = GetNumder();
    if (num > 99 && num < 999)
    {
        num = num % 10;
    }
    else if(num >= 1000 && num < 10000){
        num = num / 10;
        num = num % 10;
    }
    else if(num >= 10000 && num < 100000){
        num = num / 100;
        num = num % 10;
    }

    return num;
}

Main();

