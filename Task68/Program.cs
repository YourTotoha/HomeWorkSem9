//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//M = 4; N = 8. -> 30

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int AkkermanFormula(int NumberM, int NumberN)
{
    if (NumberM == 0)
    {
        return NumberN + 1;
    }
    else if (NumberN == 0)
    {
        return AkkermanFormula(NumberM - 1, 1);
    }
    else
    {
        return AkkermanFormula(NumberM - 1, AkkermanFormula(NumberM, NumberN - 1));
    }
}

int NumberM = GetNum("Введите значение M: ");
int NumberN = GetNum("Введите значение N: ");
int Result = AkkermanFormula(NumberM, NumberN);
Console.WriteLine($"A({NumberM},{NumberN}) = {Result}");