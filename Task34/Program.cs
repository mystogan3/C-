// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size =4)
{
    int[] Arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(100, 1000);
    }
    return Arr;
}

int CountOfPositive( int[] Arr)
{   
    int count=0;
    for (int i=0; i<Arr.Length; i++)
    {
        if (Arr[i]%2 == 0) count++;
    }
    return count;
}

int[] MyArray = GetArray(8);
Console.WriteLine($"[{string.Join(" ", MyArray)}] --> {CountOfPositive(MyArray)}");
