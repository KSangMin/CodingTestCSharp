int n = 4412;

int pos = 50;
int ans = 0;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine()!;

    int num = int.Parse(input.Substring(1));

    if (input[0] == 'R')
    {
        pos = (pos + num) % 100;
    }
    else if (input[0] == 'L')
    {
        pos = (pos - num) % 100;
        if (pos < 0)
        {
            pos += 100;
        }
    }

    if(pos == 0)
    {
        ans++;
    }
}

Console.WriteLine(ans);