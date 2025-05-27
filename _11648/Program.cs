int n = int.Parse(Console.ReadLine());

int cnt = 0;
while(n > 9)
{
    cnt++;

    int sum = 1;
    while(n > 0)
    {
        sum *= n % 10;
        n /= 10;
    }

    n = sum;
}

Console.WriteLine(cnt);