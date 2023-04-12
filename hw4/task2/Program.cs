// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(System.Console.ReadLine());
}

int num =  GetNumber();

int SumNumber(int num){
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

  int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);