int[] mn = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int m = mn[0], n = mn[1];
Console.WriteLine(m <= n ? (m - 1) * 2 : n * 2 - 1);