Console.Write("Enter number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Enter number C: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine($"{numberA},{numberB},{numberC} --> {max}");
