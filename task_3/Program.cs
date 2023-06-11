bool isData(int m, int n)
{
    return m >= 0 || n >= 0;
}

int AckermanFunctions(int start, int end)
{
    if (start == 0)
        return end + 1;
    else
    {
        if (start > 0 && end == 0)
            return AckermanFunctions(start - 1, 1);
        else
            return AckermanFunctions(start - 1, AckermanFunctions(start, end - 1)); 
    }
 
}

Console.Write("Введите число: ");
int left = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int right = int.Parse(Console.ReadLine()!);
if (isData(left, right))
    Console.Write($"M = {left}; N = {right}. -> A(m, n) = {AckermanFunctions(left, right)}");
else
    Console.WriteLine($"{left} or {right} < 0");
