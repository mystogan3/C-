// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size =4)
{
    int[] Arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(0, 101);
    }
    return Arr;
}

int GetDiffOfMaxMin(int[] Arr)
{
    int max = Arr[0];
    int min = Arr[0];
    int diff = 0;
    if (Arr.Length >= 2)
    {
        for (int i=1; i < Arr.Length; i++)
        {
            if (Arr[i] > max) max = Arr[i];
            if (Arr[i] < min) min = Arr[i];
        }
        return diff = max-min;
    }
    else return diff;   
}

int[] MyArray = GetArray(3);
Console.WriteLine($"[{string.Join(" ", MyArray)}] --> {GetDiffOfMaxMin(MyArray)}");