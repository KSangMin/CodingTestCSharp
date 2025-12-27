int n = int.Parse(Console.ReadLine()!);
string num = Console.ReadLine()!;
int k = int.Parse(Console.ReadLine()!);

int count = Math.Min(k, n);

for (int i = 0; i < count; i++)
{
    if(num[n - 1 - i] == '1')
    {
        Console.WriteLine("NO");
        return;
    }
}

Console.WriteLine("YES");