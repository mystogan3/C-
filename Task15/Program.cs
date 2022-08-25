void CheckWeekend (int NumOfDay)
{
    if (NumOfDay == 6 | NumOfDay == 7)
    {
        Console.WriteLine($"{NumOfDay} --> Yes");
    }
    else
    {
        Console.WriteLine($"{NumOfDay} --> No");
    }
}

Console.Write("Enter number from 1 to 7: ");
int Num = int.Parse(Console.ReadLine());
while (true)
{
    if ( 1 <= Num & Num <=7 )
    {
        break;
    }
    else
    {
        Console.WriteLine("You enter the wrong number");
        Console.Write("You entered number from 1 to 7: ");
        Num = int.Parse(Console.ReadLine());
    }
}

CheckWeekend(Num);
