using System.Text;

int n = int.Parse(Console.ReadLine()!);

for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;
    StringBuilder sb = new();

    char prev = s[0];
    sb.Append(prev);
    for(int j = 1; j < s.Length; j++)
    {
        if(s[j] != prev)
        {
            sb.Append(s[j]);
            prev = s[j];
        }
    }

    Console.WriteLine(sb.ToString());
}