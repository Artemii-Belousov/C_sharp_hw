// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetNum()
{
    System.Console.WriteLine("Введите длинну массива: ");
    return int.Parse(System.Console.ReadLine());
}

int num = GetNum();

int[] array = new int[num];

Method(num);

void Method(int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    System.Console.WriteLine(string.Join(", ", array));

}



