// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetNum(string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    return int.Parse(System.Console.ReadLine());
}
double [] CreateArray(int Length)
{
    double[] array = new double[Length];
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = new Random().Next(min, max + 1);

        array[i] = new Random().NextDouble() * 1000;
    }
    return array;
}

double Print(double [] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];  
        }
        else if(arr[i] < min)
        {
            min = arr[i];
        }
        System.Console.WriteLine(arr[i]);
    }
    System.Console.WriteLine($"Максимальное число массмва {max}");
    System.Console.WriteLine($"Минимальное число массмва {min}");
    double res = max - min;
    System.Console.WriteLine($"Результат {res}");
    return res;
}

int Length = GetNum("длинну массива");
// int min = GetNum("минимальное число");
// int max = GetNum("максимальное число");
double [] resalt = CreateArray(Length);
Print(resalt);











// Рабочая часть кода.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
 

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double[] d = new double[10];
//             double incr = 1.5;
//             // int i = 0;
//             for (int i = 0; i < d.Length; i++)
//             {
 
//                 d[i] = incr;
//                 incr += 2.5;
//                 Console.Write(d[i] + "; ");
//                 ++i;
                
//             }
//             Console.ReadLine();
//         }
//     }
