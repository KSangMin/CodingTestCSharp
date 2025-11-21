using System.Text;

int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int n = nm[0], m = nm[1];
bool[] check = new bool[m + 1];

StringBuilder sb = new();
for(int i = 0; i < n; i++)
{
    string[] streak = Console.ReadLine()!.Split(' ');

    int count = streak[0] == "." ? 1 : 0, max = 0;
    for(int j = 1; j < m; j++)
    {
        if(streak[j] == ".")
        {
            count++;
        }
        else
        {
            max = Math.Max(max, count);
            count = 0;
        }
    }
    max = Math.Max(max, count);
    check[max] = true;

    sb.AppendLine($"{max} {streak[m]}");
}

StringBuilder ans = new();
ans.AppendLine($"{check.Count(c => c == true)}");
ans.Append(sb.ToString());
Console.Write(ans.ToString());