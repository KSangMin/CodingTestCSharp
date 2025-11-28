using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
sb.Append(n + " ");
while (n != 1)
{
    n = (n % 2 == 0) ? n / 2 : n * 3 + 1;

    sb.Append(n + " ");
}

Console.WriteLine(sb.ToString());