int n = 200;

int ans = 0;
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;

    int maxId = 0;
    char max = '1';
    for(int j = 0; j < s.Length - 1; j++)
    {
        if(s[j] > max)
        {
            max = s[j];
            maxId = j;

            if(max == '9')
            {
                break;
            }
        }
    }

    int nMaxId = 0;
    char nMax = '1';
    for (int j = maxId + 1; j < s.Length; j++)
    {
        if (s[j] > nMax)
        {
            nMax = s[j];
            nMaxId = j;

            if (nMax == '9')
            {
                break;
            }
        }
    }

    ans += (max - '0') * 10 + (nMax - '0');
}

Console.WriteLine(ans);