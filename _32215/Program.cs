int[] nmk = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = nmk[0], m = nmk[1], k = nmk[2];

Console.WriteLine(m * (k + 1));