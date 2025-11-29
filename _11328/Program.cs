using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine()!.Split(' ');
    string a = ab[0], b = ab[1];

    string sA = string.Concat(a.OrderBy(c => c));
    string sB = string.Concat(b.OrderBy(c => c));

    sb.AppendLine(sA == sB ? "Possible" : "Impossible");
}

Console.Write(sb.ToString());