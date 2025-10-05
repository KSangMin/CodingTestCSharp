int[] p = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int ab = p[0], bc = p[1], cd = p[2];

Console.WriteLine($"{(float)(ab * cd / (float)bc):0.######}");