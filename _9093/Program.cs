using System.Text;

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    StringBuilder sb = new();
    foreach(string s in input)
    {
        for(int j = s.Length - 1; j >= 0; j--)
        {
            sb.Append(s[j]);
        }
        sb.Append(' ');
    }

    Console.WriteLine(sb.ToString());
}