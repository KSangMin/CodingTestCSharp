int[] start = Console.ReadLine()!.Split(':').Select(int.Parse).ToArray();
int[] end = Console.ReadLine()!.Split(':').Select(int.Parse).ToArray();

int[] diff = new int[3];

int s = start[0] * 3600 + start[1] * 60 + start[2];
int e = end[0] * 3600 + end[1] * 60 + end[2];

int d = e - s;
if(d <= 0) d += 24 * 3600;

diff[0] = d / 3600;
d %= 3600;
diff[1] = d / 60;
diff[2] = d % 60;

Console.WriteLine($"{diff[0]:D2}:{diff[1]:D2}:{diff[2]:D2}");