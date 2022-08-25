bool CheckNumber ( int number )
{
    if (number < 1000 & number > 99)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int FindSecondNumberOf( int number)
{
    int second = (number/10)%10;
    return second;
}

Console.Write("Enter three-digit number: ");
int Number = int.Parse(Console.ReadLine());

while(CheckNumber(Number)==false) 
{
    Console.WriteLine("Yor entered the wrong number");
    Console.Write("Enter three-digit number: ");
    Number = int.Parse(Console.ReadLine());
}

Console.Write($"The second digit of number {Number} is ");
Console.WriteLine(FindSecondNumberOf(Number));