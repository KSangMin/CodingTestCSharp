using System.Runtime.ConstrainedExecution;
using System.Text;

Dictionary<char, double> moleValues = new()
{
    {'C', 12.01f},
    {'H', 1.008f},
    {'O', 16.00f},
    {'N', 14.01f}
};

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < n; i++)
{
    string mole = Console.ReadLine()!;

    char m = mole[0];
    int j = 1, k = 0;
    double sum = 0f;

    while(j < mole.Length)
    {
        if ('A' <= mole[j] && mole[j] <= 'Z')
        {
            sum += moleValues[m] * (k < 1 ? 1 : int.Parse(mole.Substring(j - k, k)));
            m = mole[j];
            k = 0;
        }
        else
        {
            k++;
        }
        j++;
    }
    sum += moleValues[m] * (k < 1 ? 1 : int.Parse(mole.Substring(j - k, k)));

    sb.AppendLine($"{sum:F3}");
}

Console.WriteLine(sb.ToString());