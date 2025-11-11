using System.Text;

string[] s = Console.ReadLine()!.Split('-');

StringBuilder sb = new();

foreach (string w in s)
{
    sb.Append(w[0]);
}

Console.WriteLine(sb.ToString());