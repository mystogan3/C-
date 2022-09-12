// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray2D(int [,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i,j] = new Random().Next(10);
        }
    }
}

void PrintArray2D(int [,] Arr)
{
    Console.WriteLine($"rows = {Arr.GetLength(0)} and columns = {Arr.GetLength(1)}");
    Console.WriteLine();
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write(Arr[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetArithmeticMeanOfRowArray(int [,] Arr)
{
    Console.Write("ArithmeticMean of each column: ");
    for (int j = 0; j < Arr.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < Arr.GetLength(0); i++)
        {
            summ+=Arr[i,j];
        }
        Console.Write($"column №{j} = {Math.Round(summ/Arr.GetLength(0), 2)}   ");
    }
}

int [,] MyArray = new int [3,5];
FillArray2D(MyArray);
PrintArray2D(MyArray);
GetArithmeticMeanOfRowArray(MyArray);
