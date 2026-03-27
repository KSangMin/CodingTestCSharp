using System.Text;

int n = int.Parse(Console.ReadLine()!);

List<(int x, int y, int id)> points = new();
for (int i = 0; i < n; i++)
{
    int[] xy = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    points.Add((xy[0], xy[1], i + 1));
}

points = points.OrderBy(p => p.x).ThenBy(p => p.y).ToList();

StringBuilder sb = new();
for (int i = 0; i < n - 1; i++)
{
    sb.AppendLine($"{points[i].id} {points[i + 1].id}");
}

Console.Write(sb.ToString());