int[] APC = Console.ReadLine().Split().Select(int.Parse).ToArray();

int A = APC[0], P = APC[1], C = APC[2];

Console.WriteLine(Math.Max(A + C, P));