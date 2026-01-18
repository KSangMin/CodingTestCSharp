int[] hm = Console.ReadLine()!.Split(':').Select(int.Parse).ToArray();

int m = hm[0] * 60 + hm[1];
int total = 120;

while (total > 0)
{
    int diff = 0;
    if (m < 420)
    {
        diff = Math.Min(420 - m, total);
    }
    else if (m < 600)
    {
        diff = Math.Min(600 - m, total * 2);
        total += diff / 2;
    }
    else if (m < 900)
    {
        diff = Math.Min(900 - m, total);
    }
    else if (m < 1140)
    {
        diff = Math.Min(1140 - m, total * 2);
        total += diff / 2;
    }
    else
    {
        diff = total;
    }

    m = (m + diff) % 1440;
    total -= diff;
}

Console.WriteLine($"{m / 60:D2}:{m % 60:D2}");