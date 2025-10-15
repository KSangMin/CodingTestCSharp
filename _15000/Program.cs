using System.Text;

string s = Console.ReadLine()!;

StringBuilder sb = new();
foreach (char c in s)
{
    sb.Append((char)(c - 'a' + 'A'));
}

Console.WriteLine(sb.ToString());