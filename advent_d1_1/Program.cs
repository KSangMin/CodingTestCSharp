int n = 4412;

int pos = 50;
int ans = 0;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine()!;
    int num = int.Parse(input.Substring(1));

    int prev = pos;
    int diff = input[0] == 'R' ? num : -num;
    pos += diff;
    if (diff > 0)
    {
        ans += pos / 100;
    }
    else
    {
        if((prev != 0 && pos < 0)
            || pos == 0)
        {
            ans++;
        }
        ans -= pos / 100;
    }

    pos = ((pos % 100) + 100) % 100;
}

Console.WriteLine(ans);