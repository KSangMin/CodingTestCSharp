int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();

int x = xy[0], y = xy[1], p1 = xy[2], p2 = xy[3];

int ans = 0;

while(p1 <= 10000 && p2 <= 10000)
{
    if(p1 == p2)
    {
        Console.WriteLine(p1);
        return;
    }
    else if(p1 < p2)
    {
        p1 += x;
    }
    else
    {
        p2 += y;
    }
}

Console.WriteLine(-1);