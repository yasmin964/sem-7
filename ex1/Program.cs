﻿// Задача 46: Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1
int[,] GetArray(int m,int n,int minValue,int maxValue)
{
    int [,] result=new int[m,n];
    for (int i=0;i<m;i++)
    {
       for (int j=0;j<n;i++) 
       {
        result[i,j]=new Random().Next(minValue, maxValue +1);
       }
    }
    return result;
}
void PrintArray(int [,] inArray)
{
    for (int i=0;i<inArray.GetLength(0);i++)
    {
        for (int j=0;j<inArray.GetLength(0);j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
