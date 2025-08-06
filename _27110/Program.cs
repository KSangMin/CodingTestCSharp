int n = int.Parse(Console.ReadLine());

int[] ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();

int ans = 0;

for(int i = 0; i < 3; i++)
{
    if (ABC[i] >= n)
    {
        ans += n;
    }
    else
    {
        ans += ABC[i];
    }
}

Console.WriteLine(ans);