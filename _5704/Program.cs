using System.Text;

StringBuilder sb = new();

while (true)
{
    string s = Console.ReadLine()!;
    if(s == "*")
    {
        break;
    }

    if(s.Length < 26)
    {
        sb.AppendLine("N");
    }
    else
    {
        bool[] check = new bool[26];

        foreach (char c in s)
        {
            if (c != ' ')
            {
                check[c - 'a'] = true;
            }
        }

        bool flag = true;
        foreach(bool b in check)
        {
            if (!b)
            {
                flag = false;
                break;
            }
        }

        sb.AppendLine(flag ? "Y" : "N");
    }
}

Console.Write(sb.ToString());