Console.Write("Enter number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = int.Parse(Console.ReadLine());

if ( numberA > numberB)
{
    Console.WriteLine($"a = {numberA}; b = {numberB} --> max = {numberA}");
}
else 
{
    Console.WriteLine($"a = {numberA}; b = {numberB} --> max = {numberB}");
}