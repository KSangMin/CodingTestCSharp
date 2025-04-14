int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int diff = input[0] + input[3] - input[1] - input[2];

Console.WriteLine(MathF.Abs(diff));