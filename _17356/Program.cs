int[] WJ = Console.ReadLine().Split().Select(int.Parse).ToArray();
double M = (WJ[1] - WJ[0]) / 400f;

Console.WriteLine(1 / (1 + Math.Pow(10, M)));