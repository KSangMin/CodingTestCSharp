using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    List<int> prices = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();
    List<int> ans = new();

    int j = 0;
    while(j < prices.Count)
    {
        if (prices[j] % 3 == 0)
        {
            for(int k = j + 1; k < prices.Count; k++)
            {
                if (prices[k] == prices[j] / 3 * 4)
                {
                    ans.Add(prices[j]);
                    prices.RemoveAt(k);
                    break;
                }
            }
        }
        j++;
    }

    sb.AppendLine($"Case #{i + 1}: " + string.Join(' ', ans));
}

Console.Write(sb.ToString());