long[] hpatk = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
long hh = hpatk[0], ha = hpatk[1], bh = hpatk[2], ba = hpatk[3];
long[] ps = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
long p = ps[0], s = ps[1];

Character hero = new(hh, ha);
Boss boss = new(bh, ba, p, s);

Console.WriteLine(Fight(hero, boss) ? "Victory!" : "gg");

bool Fight(Character h, Boss b)
{
    long turnsToHeal = (b.h - b.p + h.a - 1) / h.a;
    long heroSurviveTurns = (h.h + b.a - 1) / b.a;

    if (heroSurviveTurns >= turnsToHeal)
    {
        b.h -= turnsToHeal * h.a;
        h.h -= turnsToHeal * b.a;

        if (b.h <= 0)
        {
            return true;
        }

        b.h += b.s;

        long heroWinTurns = (b.h + h.a - 1) / h.a;
        long bossWinTurns = (h.h + b.a - 1) / b.a;

        if (heroWinTurns <= bossWinTurns)
        {
            return true;
        }
    }

    return false;
}

class Character
{
    public long h;
    public long a;

    public Character(long health, long attack)
    {
        h = health;
        a = attack;
    }
}

class Boss : Character
{
    public long p;
    public long s;

    public Boss(long health, long attack, long p, long s) : base(health, attack)
    {
        this.p = p;
        this.s = s;
    }
}