int n = int.Parse(Console.ReadLine());

int cnt = 0;
for (int i = 1; i <= 999; i++)
{
    for(int j = i + 1; j <= 1000; j++)
    {
        int iSqr = i * i;
        int jSqr = j * j;

        if (iSqr + n == jSqr)
        {
            cnt++;
        }
        else if (iSqr + n < jSqr)
        {
            break;
        }
    }
}

Console.WriteLine(cnt);