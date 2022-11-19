// Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.
int[,] GetArray(int m,int n)
{
    int [,] result=new int[m,n];
    for (int i=0;i<m;i++)
    {
       for (int j=0;j<n;i++) 
       {
        result[i,j]=new Random().Next(0,10);
       }
    }
    return result;
}
void squareEvenIndexes(int[,] array)
{for (int i=0;i<inArray.GetLength(0);i++)
int [,] res=new int[m,n];
    for (int i=0;i<m;i+=2)
    {
       for (int j=0;j<n;i+=2) 
       {
        res[i,j]*=res[i,j];
       }
}
}
void PrintArray(int [,] inArray)
{
    for (int i=0;i<inArray.GetLength(0);i++)
    {
        for (int j=0;j<inArray.GetLength(1);j++)
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
squareEvenIndexes(array);
int[,] array = GetArray(rows, cols,0,10);
PrintArray(array);