int n = int.Parse(Console.ReadLine());

Dictionary<int, int> cows = new Dictionary<int, int>();
int ans = 0;

for(int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int cow = input[0], pos = input[1];
    if (cows.ContainsKey(cow) && cows[cow] != pos) ans++;
    cows[cow] = pos;
}

Console.WriteLine(ans);