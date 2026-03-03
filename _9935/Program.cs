using System.Text;

ExplodeString();

void ExplodeString()
{
    string s = Console.ReadLine()!;
    string bomb = Console.ReadLine()!;
    int b = bomb.Length;
    char bombLast = bomb[b - 1];

    StringBuilder sb = new();
    foreach (char c in s)
    {
        sb.Append(c);

        if(c == bombLast && sb.Length >= b)
        {
            sb.Replace(bomb, "", sb.Length - b, b);
        }
    }

    Console.WriteLine(sb.Length > 0 ? sb.ToString() : "FRULA");
}
