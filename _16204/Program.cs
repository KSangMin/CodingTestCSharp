int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int baseO = input[1], baseX = input[0] - input[1];
int newO = input[2], newX = input[0] - input[2];

int sum = (int)(MathF.Min(baseO, newO) + MathF.Min(baseX, newX));

Console.WriteLine(sum);