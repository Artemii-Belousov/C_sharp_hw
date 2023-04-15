// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] CreateArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}
int Num(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    return int.Parse(System.Console.ReadLine());
}
int EvenNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
        
    }
    System.Console.WriteLine($"Количество четных чисел {count}");
    return count;
}
int Length = Num("длинну массива");
int min = Num("минимальное число массива");
int max = Num("максимальное число массива");
int [] result = CreateArray(Length, min, max);
PrintArray(result);
int Even = EvenNumber(result);