
bool isData(int m, int n)
{
    return m < n;
}

int SumNumbersBetween(int start, int end)
{
    if (start < end)
        return start + SumNumbersBetween(start + 1, end); 
    else
        return start;
}

Console.Write("Введите число: ");
int left = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int right = int.Parse(Console.ReadLine()!);
if (isData(left, right))
{
    Console.Write($"M = {left}; N = {right}. -> {SumNumbersBetween(left, right)}");
    
}
else
    Console.WriteLine($"{left} > {right}");