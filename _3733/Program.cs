using System.Text;

string line;
StringBuilder sb = new();

while ((line = Console.ReadLine()) != null)
{
    int[] ns = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    sb.AppendLine((ns[1] / (ns[0] + 1)).ToString());
}

Console.Write(sb.ToString());