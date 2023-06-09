﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] CreateArray(int x, int b)
{
    double [,] Array = new double[x, b];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
        }
    }
    return Array;
}

void PrintArray(double [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int GetNum(string arg){
    System.Console.WriteLine($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

int m = GetNum("колличество строк");
int n = GetNum("колличество столбцов");

PrintArray(CreateArray(m, n));