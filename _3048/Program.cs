int[] ns = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n1 = ns[0], n2 = ns[1];
List<Ant> a = Console.ReadLine()!.Select(c => new Ant(c, true)).ToList();
List<Ant> b = Console.ReadLine()!.Select(c => new Ant(c, false)).ToList();
a.Reverse();
List<Ant> ants = a.Concat(b).ToList();
int t = int.Parse(Console.ReadLine()!);

while (t > 0)
{
    bool isChanged = false;
    for (int i = 0; i < ants.Count - 1; i++)
    {
        if (ants[i].isLeft && !ants[i + 1].isLeft)
        {
            Ant temp = ants[i];
            ants[i] = ants[i + 1];
            ants[i + 1] = temp;
            i++;
            isChanged = true;
        }
    }

    if (!isChanged)
    {
        break;
    }

    t--;
}

Console.WriteLine(string.Concat(ants.Select(ant => ant.c)));

class Ant
{
    public char c;
    public bool isLeft;

    public Ant(char c, bool isLeft)
    {
        this.c = c;
        this.isLeft = isLeft;
    }
}