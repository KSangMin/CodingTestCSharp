int[] ts = Console.ReadLine().Split().Select(int.Parse).ToArray();

int t = ts[0], s = ts[1];

Console.WriteLine(s == 1 || t <= 11 || t > 16 ? 280 : 320);