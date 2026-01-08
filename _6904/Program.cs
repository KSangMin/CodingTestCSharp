using System.Text;

int n;

StringBuilder sb = new();
while ((n = int.Parse(Console.ReadLine()!)) != 0)
{
    int mA = 1, mB = n;

    for(int i = 1; i * i <= n; i++)
    {
        if(n % i == 0)
        {
            mA = i;
            mB = n / i;
        }
    }

    sb.AppendLine($"Minimum perimeter is {2 * (mA + mB)} with dimensions {mA} x {mB}");
}

Console.WriteLine(sb.ToString());