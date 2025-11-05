using System.Text;

string s = Console.ReadLine()!;

StringBuilder sb = new();

char before = s[0];
sb.Append(before);
foreach (char c in s)
{
    if(before != c)
    {
        sb.Append(c);
    }
    before = c;
}

Console.WriteLine(sb.ToString());