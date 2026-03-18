using System.Text;

List<int> pre = new();

using (StreamReader sr = new(Console.OpenStandardInput()))
{
    while (!sr.EndOfStream)
    {
        pre.Add(int.Parse(sr.ReadLine()!));
    }
}

StringBuilder sb = new();
MakePost(sb, pre, 0, pre.Count);

Console.Write(sb.ToString());

void MakePost(StringBuilder sb, List<int> pre, int start, int end)
{
    if(start >= end)
    {
        return;
    }

    int root = pre[start];
    int i = start + 1;
    while (i < end && pre[i] < root)
    {
        i++;
    }

    MakePost(sb, pre, start + 1, i);
    MakePost(sb, pre, i, end);
    sb.AppendLine($"{root}");
}