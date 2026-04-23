int[] order = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = order.Length - 1;
int[,,] dp = new int[n, 5, 5];

Console.WriteLine(Solve(order, dp, 0, 0, 0));

int Solve(int[] order, int[,,] dp, int id, int left, int right)
{
    if (id == order.Length - 1)
    {
        return 0;
    }

    if (dp[id, left, right] != 0)
    {
        return dp[id, left, right];
    }

    int lCost = CheckLessCost(left, order[id]) + Solve(order, dp, id + 1, order[id], right);
    int rCost = CheckLessCost(right, order[id]) + Solve(order, dp, id + 1, left, order[id]);

    return dp[id, left, right] = Math.Min(lCost, rCost);
}

int CheckLessCost(int foot, int target)
{
    if (foot == target)
    {
        return 1;
    }
    else if (foot == 0)
    {
        return 2;
    }
    else if (Math.Abs(target - foot) == 2)
    {
        return 4;
    }
    else
    {
        return 3;
    }
}