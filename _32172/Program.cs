int n = int.Parse(Console.ReadLine()!);

HashSet<int> arr = new() { 0 };

int before = 0;
for (int i = 1; i <= n; i++)
{
    int next = before - i;
    if (next < 0 || arr.Contains(next))
    {
        next = before + i;
    }

    arr.Add(next);
    before = next;
}

Console.WriteLine(before);