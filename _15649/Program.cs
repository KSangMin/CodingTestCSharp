using System.Text;

int[] combi = new int[9];
bool[] visited = new bool[9];

int[] nm = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

StringBuilder sb = new();
dfs(sb, 0);

Console.WriteLine(sb.ToString());

void dfs(StringBuilder s, int depth)
{
    if (depth == m)
    {
        for (int i = 1; i <= m; i++)
        {
            s.Append(combi[i]).Append(" ");
        }
        s.AppendLine();
    }
    else
    {
        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                combi[depth + 1] = i;
                dfs(s, depth + 1);
                visited[i] = false;
            }
        }
    }

    return;
}