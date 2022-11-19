// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
void  GetArray(double[,] inArray)
{
   
    for ( int i=0;i<inArray.GetLength(0);i++)
    {
       for ( int j=0;j<inArray.GetLength(1);i++) 
       {
        inArray[i,j]=Convert.ToDouble(new Random().Next(-100, 100)) / 10;
       }
    }
  
}
void PrintArray(double[,] inArray)

{    for (int i=0;i<inArray.GetLength(0);i++)
    {
        for ( int j=0;j<inArray.GetLength(0);j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows =int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
double[,] result=new double[rows,cols];
GetArray(result);
PrintArray(result);