Console.Write("Enter number: ");
int numberA = int.Parse(Console.ReadLine());
int index = 2;

if (numberA < 2)
{
    Console.WriteLine("No numbers");
}
else
{
    Console.Write($"{numberA} --> ");
    while (index <= numberA)
    {
        Console.Write($"{index}, ");
        index+=2;
    }
}


