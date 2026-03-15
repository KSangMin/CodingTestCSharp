using System.Text;

int k = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 1; i <= k; i++)
{
    int[] ea = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int e = ea[0], a = ea[1];

    sb.AppendLine($"Data Set {i}:");
    if(e > a)
    {
        a *= 5;
        while (e > a)
        {
            sb.Append($"mega ");

            a *= 5;
        }
    }
    else
    {
        sb.Append("no ");
    }

    sb.AppendLine("drought\n");
}

Console.Write(sb.ToString());