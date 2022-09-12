// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

void FillArray2D(int [,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray2D(int [,] Arr)
{
    Console.WriteLine($"rows = {Arr.GetLength(0)} and columns = {Arr.GetLength(1)}");
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write(Arr[i,j]);
        }
        Console.WriteLine();
    }

}

int [,] MyArray = new int [3,4];
FillArray2D(MyArray);
PrintArray2D(MyArray);


