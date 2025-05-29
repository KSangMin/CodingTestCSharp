int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = NK[0], k = NK[1];

List<int> gs = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> ds = new();

for(int i = 0; i < k; i++)
{
    int g = gs[i], d;
    int r = g * 100 / n;

    if (r <= 4) d = 1;
    else if (r <= 11) d = 2;
    else if (r <= 23) d = 3;
    else if (r <= 40) d = 4;
    else if (r <= 60) d = 5;
    else if (r <= 77) d = 6;
    else if (r <= 89) d = 7;
    else if (r <= 96) d = 8;
    else d = 9;

    ds.Add(d);
}

for(int i = 0; i < k; i++)
{
    Console.Write($"{ds[i]} ");
}