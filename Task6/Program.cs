Console.Write("Enter number: ");
int numberA = int.Parse(Console.ReadLine());

if ((numberA % 2) == 0)
{
    Console.WriteLine($"{numberA} --> Yes");
}
else
{
    Console.WriteLine($"{numberA} --> No");
}
