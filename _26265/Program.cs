using System.Text;

int N = int.Parse(Console.ReadLine());
List<KeyValuePair<string, string>> pairs = new();
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    pairs.Add(new(input[0], input[1]));
}

pairs.Sort((a, b) =>
{
    int cmp = a.Key.CompareTo(b.Key);
    if (cmp != 0) return cmp;
    return b.Value.CompareTo(a.Value);
});

StringBuilder sb = new();
foreach (var pair in pairs)
{
    sb.AppendLine($"{pair.Key} {pair.Value}");
}

Console.Write(sb.ToString());