int m = int.Parse(Console.ReadLine()!);

float n = 0;
if(m <= 30)
{
    n = m / 2f;
}
else
{
    n += 15;
    n += (m - 30) * 3 / 2f;
}

Console.WriteLine($"{n:F1}");