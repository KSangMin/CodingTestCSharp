int[] cash = { 0, 100, 500, 1000, 5000, 10000, 25000, 50000, 100000, 500000, 1000000 };
List<int> brief = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    int b = int.Parse(Console.ReadLine()!);

    brief.Remove(b);
}

int offer = int.Parse(Console.ReadLine()!);

double avg = brief.Average(x => cash[x]);

Console.WriteLine(avg < offer ? "deal" : "no deal");