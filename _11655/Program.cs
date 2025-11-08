using System.Text;

string s = Console.ReadLine()!;

StringBuilder sb = new();

foreach(char c in s)
{
    if('a' <= c && c <= 'z')
    {
        int ca = c + 13;
        if(ca > 'z')
        {
            ca -= 26;
        }
        sb.Append((char)ca);
    }
    else if('A' <= c && c <= 'Z')
    {
        int ca = c + 13;
        if (ca > 'Z')
        {
            ca -= 26;
        }
        sb.Append((char)ca);
    }
    else
    {
        sb.Append(c);
    }
}

Console.WriteLine(sb.ToString());