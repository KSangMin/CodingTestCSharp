int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();

int x = xy[0], y = xy[1];

bool ytPhase = true;
while(x < 5 && y < 5)
{
    if (ytPhase) y += x;
    else x += y;

    ytPhase = !ytPhase;
}

Console.WriteLine(x < y ? "yt" : "yj");