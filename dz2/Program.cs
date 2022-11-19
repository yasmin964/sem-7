// Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
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
Console.Write("Введите число,которое нужно найти: ");
int N = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
int [,] result=new int[rows,cols];
if (rows> result.GetLength(0) || cols >result.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows} строки и {cols} столбца равно {result[rows-1,cols-1]}");
}

