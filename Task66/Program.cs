//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int SumNumbers(int NumberM, int NumberN)
{
    if (NumberM > NumberN) 
    {
        return 0;
    }
    else 
    {
        return NumberM + SumNumbers(NumberM + 1, NumberN);
    }
}

int NumberM = GetNum("Введите значение M: ");
int NumberN = GetNum("Введите значение N: ");

int sum = SumNumbers(NumberM, NumberN);
Console.Write($"M = {NumberM}; N = {NumberN} -> {sum}");