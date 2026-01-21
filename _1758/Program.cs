int n = int.Parse(Console.ReadLine()!);

List<int> people = new();

for(int i = 0; i < n; i++)
{
    people.Add(int.Parse(Console.ReadLine()!));
}

people.Sort();

long sum = 0;
for(int i = n - 1; i >= 0; i--)
{
    int tip = people[i] - (n - 1 - i);
    if (tip <= 0)
    {
        break;
    }
    sum += Math.Max(0, tip);
}

Console.WriteLine(sum);