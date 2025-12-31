int[] nk = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];

int count = 0;
for(int i = 1; i <= n; i++)
{
    if(n % i == 0)
    {
        count++;
        if(count == k)
        {
            Console.WriteLine(i);
            return;
        }
    }
}

Console.WriteLine(0);