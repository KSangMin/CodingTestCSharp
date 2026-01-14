using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < n; i++)
{
    int[] ab = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int a = ab[0], b = ab[1];

    Stack<int> aAncestor = new();
    Stack<int> bAncestor = new();

    while (a > 0)
    {
        aAncestor.Push(a);
        a /= 2;
    }
    while (b > 0)
    {
        bAncestor.Push(b);
        b /= 2;
    }

    int min = 1023;
    int count = Math.Min(aAncestor.Count, bAncestor.Count);
    for (int j = 0; j < count; j++)
    {
        if (aAncestor.Peek() == bAncestor.Peek())
        {
            min = aAncestor.Peek();
            aAncestor.Pop();
            bAncestor.Pop();
        }
        else
        {
            break;
        }
    }

    sb.AppendLine((min * 10).ToString());
}

Console.WriteLine(sb.ToString());