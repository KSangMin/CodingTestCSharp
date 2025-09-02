using System.Text;

string abc = Console.ReadLine();

StringBuilder sb = new();
for(int i = 0; i < abc.Length; i++)
{
    sb.Append(abc[abc.Length - i - 1]);
}

Console.WriteLine(sb.ToString());