int[] nmk = Console.ReadLine().Split().Select(int.Parse).ToArray();

int N = nmk[0], M = nmk[1], K = nmk[2];

int n = K / M, m = K % M;

Console.WriteLine($"{n} {m}");