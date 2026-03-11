int[] nk = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];
int[] arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

Array.Sort(arr);
int[] sum = new int[k];
int ans = 0;
for (int i = 0; i < n; i++)
{
    int optId = Array.IndexOf(sum, sum.Min());
    sum[optId] += arr[i];
    ans += sum[optId];
}

Console.WriteLine(ans);