using System.Text;

SortedSet<string> set = new();
for(int i = 0; i < 2; i++)
{
    foreach (string s in Console.ReadLine()!.Split())
    {
        set.Add(s);
    }
}

StringBuilder sb = new();
foreach (string s1 in set)
{
    foreach (string s2 in set)
    {
        sb.AppendLine($"{s1} {s2}");
    }
}

Console.Write(sb.ToString());