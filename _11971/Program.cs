int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = NM[0], M = NM[1];

List<int> limit = new();
List<int> speed = new();

for (int i = 0; i < N; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for(int j = 0; j < input[0]; j++)
    {
        limit.Add(input[1]);
    }
}
for (int i = 0; i < M; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < input[0]; j++)
    {
        speed.Add(input[1]);
    }
}

int max = 0;

for (int i = 0; i < 100; i++)
{
    if (speed[i] > limit[i])
    {
        max = Math.Max(max, speed[i] - limit[i]);
    }
}

Console.WriteLine(max);