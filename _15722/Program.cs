int[] dX = { 0, 1, 0, -1 };
int[] dY = { 1, 0, -1, 0 };

int n = int.Parse(Console.ReadLine()!);

int cur = 0, count = 0, x = 0, y = 0;
for(int i = 1; i <= n; i++)
{
    for(int j = 0; j < (i + 1) / 2; j++)
    {
        count++;
        x += dX[cur];
        y += dY[cur];

        if(count == n)
        {
            Console.WriteLine($"{x} {y}");
            return;
        }
    }
    cur = (cur + 1) % 4;
}

Console.WriteLine($"{x} {y}");