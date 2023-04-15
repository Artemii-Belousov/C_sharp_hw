// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int GetNum(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    return int.Parse(System.Console.ReadLine());
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

int Result(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2  != 0) sum = sum + arr[i];
    }
    System.Console.WriteLine($"Результат: {sum}");
    
    return sum;
}

int length = GetNum("длинну массива");
int min = GetNum("минимальное значине");
int max = GetNum("максимальное значение");
int[] resalt = CreateArray(length, min, max);
PrintArray(resalt);
int result = Result(resalt);
