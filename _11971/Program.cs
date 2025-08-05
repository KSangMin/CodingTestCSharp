int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = NM[0], M = NM[1];

Console.WriteLine(N / 2 < M / 2 ? N / 2 : M / 2);