int[] wh = Console.ReadLine().Split().Select(int.Parse).ToArray();

int w = wh[0], h = wh[1];

Console.WriteLine((w * h / 2f).ToString("F1"));