int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = nk[0], k = nk[1];
int firstK = k % 10;
int first2K = (2 * k) % 10;
List<int> ans = new();

for (int i = 1; i <= n; i++)
{
    int first = i % 10;
    if (first != firstK && first != first2K) ans.Add(i);
}

Console.WriteLine(ans.Count);
for(int i = 0; i < ans.Count; i++)
{
    Console.Write($"{ans[i]} ");
}