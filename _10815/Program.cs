using System.Text;

int n = int.Parse(Console.ReadLine());
HashSet<int> card = Console.ReadLine().Split().Select(int.Parse).ToHashSet<int>();

int m = int.Parse(Console.ReadLine());
int[] check = Console.ReadLine().Split().Select(int.Parse).ToArray();

StringBuilder sb = new();
foreach(int c in check)
{
    sb.Append(card.Contains(c) ? "1 " : "0 ");
}

Console.WriteLine(sb.ToString());