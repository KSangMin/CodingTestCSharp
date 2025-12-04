using System.Text;

int[] abcd = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int a = abcd[0], b = abcd[1], c = abcd[2], d = abcd[3];

StringBuilder sb = new();
for (int i = 0; i <= 250; i++)
{
    for(int j = 0; j <= 250; j++)
    {
        for(int k = 0; k <= 250; k++)
        {
            int sum = a * i + b * j + c * k;
            if(sum == d)
            {
                sb.AppendLine($"{i} {j} {k}");
            }
            else if(sum > d)
            {
                break;
            }
        }
    }
}

Console.Write(sb.Length > 0 ? sb.ToString() : "impossible");