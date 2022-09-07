// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел происходит через Enter, останавливается при введении слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using System;

void GetPositiveCount()
{
    int count = 0;
    while (true)
    {
        Console.Write("Enter a number: ");
        string value = Console.ReadLine();
        if (value.ToLower() == "stop") break;
        int TempValue=0;
        if (int.TryParse(value, out TempValue))
        {
            if (TempValue > 0) count++;
        }
        else continue;
    }
    Console.WriteLine($"You entered {count} positives numbers");
}
GetPositiveCount();


