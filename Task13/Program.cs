void FindThirdNumberOf ( int number)
{
    if (number < 100)
    {
        Console.WriteLine($"{number} --> no third digit");
    }
    else
    {   
        int ThirdDigit = number;
        while (ThirdDigit > 999)
        {
            ThirdDigit = ThirdDigit/10;
        }
    ThirdDigit = ThirdDigit%10;
    Console.WriteLine($"{number} --> {ThirdDigit}");
    }
}

Console.Write("Ether a number: ");
int Number = int.Parse(Console.ReadLine());
FindThirdNumberOf(Number);

