// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.



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

void CheckArrayElement( int [,] Arr, int Row, int Column)
{
    if (Arr.GetLength(0) > Row & Arr.GetLength(1) > Column) 
        {Console.WriteLine($"Your element = {Arr[Row,Column]}");}
    else Console.WriteLine("There isn't any elenent in your array");
}

Console.Write("Enter row's number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column's number: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] MyArray = new int [5,5];
FillArray2D(MyArray);
PrintArray2D(MyArray);
CheckArrayElement(MyArray, Row:row, Column:column);


