using System.Text;

int n = int.Parse(Console.ReadLine()!);

string s = Console.ReadLine()!;

int sum = 0;
StringBuilder sb = new();
foreach (char c in s)
{
    if (c == '.' || c == '|' || c == ':' || c == '#')
    {
        sum += int.Parse(sb.ToString());
        sb.Clear();
    }
    else
    {
        sb.Append(c);
    }
}

Console.WriteLine(sum + int.Parse(sb.ToString()));