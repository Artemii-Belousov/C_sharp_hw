// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = GetNumber();
int result = FindNum(number);
System.Console.WriteLine(result);

int GetNumber(){
    System.Console.WriteLine("Введите число: ");
    return int.Parse(System.Console.ReadLine());
}

int FindNum(int num){
    int FirstNum = num % 100;
    int MidleNum = FirstNum / 10;
    return MidleNum;
}


