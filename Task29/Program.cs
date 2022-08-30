
void GetArr(int number)
{
    int[] Array = new int[number];
    for (int i=0; i<number; i++)
    {
        int random = new Random().Next(1,100);
        Array[i]=random;
    }
    Console.WriteLine($"{string.Join(",", Array)} --> [{string.Join(", ", Array)}]");
}

GetArr(8);