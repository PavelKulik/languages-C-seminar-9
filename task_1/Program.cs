
bool isData(int m, int n)
{
    return m < n;
}

void NumbersBetween(int start, int end)
{
    Console.Write($" {start}");
    if (start < end)
        NumbersBetween(start + 1, end);        
}

Console.Write("Введите число: ");
int left = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int right = int.Parse(Console.ReadLine()!);
if (isData(left, right))
{
    Console.Write($"M = {left}; N = {right}. ->");
    NumbersBetween(left, right);
}
else
    Console.WriteLine($"{left} > {right}");