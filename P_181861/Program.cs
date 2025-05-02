int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[] node = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int x1 = node[0], y1 = node[1], r1 = node[2], x2 = node[3], y2 = node[4], r2 = node[5];

    int sqrDistance = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);

    int ans = 0;
    if(sqrDistance == 0 && r1 == r2) ans = -1;
    else
    {
        int sum = (r1 + r2) * (r1 + r2);
        int diff = (r1 - r2) * (r1 - r2);
        if (sum == sqrDistance || diff == sqrDistance) ans = 1;
        else if (diff < sqrDistance && sqrDistance < sum) ans = 2;
    }

    Console.WriteLine(ans);
}