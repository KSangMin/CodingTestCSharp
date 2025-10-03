using System.Text;

int[] NB = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int n = NB[0], b = NB[1];

StringBuilder sb = new();
while (n > 0)
{
    int a = n % b;
    sb.Insert(0, a > 9 ? (char)('A' + a - 10) : (char)('0' + a));

    n /= b;
}

Console.WriteLine(sb.ToString());
