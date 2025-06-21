int n = int.Parse(Console.ReadLine());

int ans = 1;
for(int i  = 2; i <= n; i++)
{
    ans *= i;
}

Console.WriteLine(ans);