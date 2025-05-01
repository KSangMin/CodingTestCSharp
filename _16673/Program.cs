int[] nkp = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = nkp[0], k = nkp[1], p  = nkp[2];

int sum = 0;
for(int i = 1;  i <= n; i++)
{
    sum += (k + p * i) * i;
}

Console.WriteLine(sum);