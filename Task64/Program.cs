//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int Number)
{
    if (Number == 1)
    {
        Console.Write("1");
    }
    else
    {
        Console.Write($"{Number}, ");
        PrintNumbers(Number - 1);
    }
}

int Number = GetNum("Введите значение N: ");
Console.Write($"N = {Number} -> '");
PrintNumbers(Number);
Console.Write("'");