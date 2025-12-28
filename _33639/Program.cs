using System.Text;

int[] nq = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nq[0], q = nq[1];

Dictionary<string, List<string>> customer = new();
for (int i = 0; i < n; i++)
{
    string[] name = Console.ReadLine()!.Split(' ');

    string initial = $"{name[0][0]}{name[1][0]}";

    if (!customer.ContainsKey(initial))
    {
        customer[initial] = new List<string>();
    }
    customer[initial].Add(string.Join(" ", name));
}

StringBuilder sb = new();
for (int i = 0; i < q; i++)
{
    string query = Console.ReadLine()!;

    if (customer.ContainsKey(query))
    {
        if (customer[query].Count > 1)
        {
            sb.AppendLine("ambiguous");
        }
        else
        {
            sb.AppendLine(customer[query][0]);
        }
    }
    else
    {
        sb.AppendLine("nobody");
    }
}

Console.Write(sb.ToString());