int[] stat = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int N = stat[4], sum = stat.Sum() - N;
float avg = sum / 4f;

Console.WriteLine(N > avg ? (N - avg) * 4 : 0);