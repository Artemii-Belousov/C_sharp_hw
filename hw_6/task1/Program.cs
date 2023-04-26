// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Length = GetNum("длину массива");
int min = GetNum("минимальное число");
int max = GetNum("максимальное число");
int[] NewArray = CreateArray(Length, min, max);
PrintArray(NewArray);

int GetNum(string num)
{
    System.Console.WriteLine($"Введите {num}: ");
    return int.Parse(System.Console.ReadLine());
}

int[] CreateArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    // System.Console.WriteLine("[");
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.WriteLine(array[i]);

        if (array[i] > 0)
        {
            counter++;
        }


    }
    System.Console.WriteLine($"Чисел больше 0: {counter}"); 

}

