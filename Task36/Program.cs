// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size =4)
{
    int[] Arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(-100, 101);
    }
    return Arr;
}

int GetSumNegPosit ( int[] Arr)
{
    int sum = 0;
    for (int i=1; i<Arr.Length; i+=2)
    {
        sum += Arr[i];
    }
    return sum;
}

int[] MyArray = GetArray(6);
Console.WriteLine($"[{string.Join(" ", MyArray)}] --> {GetSumNegPosit(MyArray)}");
