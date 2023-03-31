// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int number = GetNumber();

int result = Compare(number);
int GetNumber()
{
    System.Console.WriteLine("Enter a number: ");
    return int.Parse(System.Console.ReadLine());
}

int Compare(int num){

    int firstNum = num / 10000;
    int lastNum = num % 10;
    int secondNum = num / 1000 % 10;
    int penultimateNum = num % 100 /10;

    if(firstNum == lastNum && secondNum == penultimateNum){
        System.Console.WriteLine("Equal");
    }
    else
    {
        System.Console.WriteLine("Not equal");
    }
    return num;
    }






