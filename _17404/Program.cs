int n = int.Parse(Console.ReadLine()!);
List<int[]> houses = new();
for(int i = 0; i < n; i++)
{
    houses.Add(Console.ReadLine()!.Split().Select(int.Parse).ToArray());
}

int min = int.MaxValue;
for(int i = 0; i < 3; i++)
{
    min = Math.Min(min, DP(houses, i));
}

Console.WriteLine(min);

int DP(List<int[]> houses, int start)
{
    int n = houses.Count;
    int[,] dp = new int[n, 3];
    int INF = 1000 * 1000 + 1; // 최대 비용보다 큰 값

    // 1. 첫 번째 집 초기화
    for (int i = 0; i < 3; i++)
    {
        if (i == start) dp[0, i] = houses[0][i];
        else dp[0, i] = INF; // 선택하면 안 되는 색은 무한대 처리
    }

    // 2. 2번째 집부터 마지막 집까지 동일하게 계산
    for (int i = 1; i < n; i++)
    {
        dp[i, 0] = houses[i][0] + Math.Min(dp[i - 1, 1], dp[i - 1, 2]);
        dp[i, 1] = houses[i][1] + Math.Min(dp[i - 1, 0], dp[i - 1, 2]);
        dp[i, 2] = houses[i][2] + Math.Min(dp[i - 1, 0], dp[i - 1, 1]);
    }

    // 3. 마지막 집(n-1)에서 첫 번째 집(start)과 다른 색상 중 최솟값 찾기
    int result = INF;
    for (int i = 0; i < 3; i++)
    {
        if (i == start) continue; // 첫 집과 같은 색은 패스
        result = Math.Min(result, dp[n - 1, i]);
    }

    return result;
}