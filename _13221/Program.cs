int[] start = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int sX = start[0], sY = start[1];
int n = int.Parse(Console.ReadLine()!);

int min = int.MaxValue, mX = 0, mY = 0;
for (int i = 0; i < n; i++)
{
    int[] point = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int pX = point[0], pY = point[1];
    
    int manhatanDistance = Math.Abs(sX - pX) + Math.Abs(sY - pY);
    if (manhatanDistance < min)
    {
        min = manhatanDistance;
        mX = pX;
        mY = pY;
    }
}

Console.WriteLine($"{mX} {mY}");