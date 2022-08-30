int x = new Random().Next(1,11);
int y = new Random().Next(1,11);

double GetPower(int numberA, int numberB)
{
    return Math.Pow(numberA, numberB);
}

Console.WriteLine($"{x},{y} --> "+GetPower(x,y));
