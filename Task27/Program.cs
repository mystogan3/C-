int x = new Random().Next(0,10000);

int SumOfNumbers(int number)
{
    int sum = 0;
    while (number >= 10)
    {
        sum += number%10;
        number /=10;

    }
    return sum+=number;

}
Console.WriteLine($"{x} --> "+SumOfNumbers(x));