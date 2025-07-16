int[] rcn = Console.ReadLine().Split().Select(int.Parse).ToArray();

long r = rcn[0], c = rcn[1], n = rcn[2];

Console.WriteLine(((r + n - 1) / n) * ((c + n - 1) / n));