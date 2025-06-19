int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
long x = xy[0], y = xy[1], z = y * 100 / x;

if (z >= 99) Console.WriteLine("-1");
else
{
    long left = 1, right = x, mid = (left + right) / 2;

    while (left < right)
    {
        long ratio = (y + mid) * 100 / (x + mid);
        if (ratio <= z) left = mid + 1;
        else right = mid;

        mid = (left + right) / 2;
    }

    Console.WriteLine(mid);
}