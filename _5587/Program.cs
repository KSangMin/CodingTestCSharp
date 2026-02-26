const int MAX = 201;

int n = int.Parse(Console.ReadLine()!);

List<int> sg = new();
List<int> gs = new();
for (int i = 0; i < n; i++)
{
    sg.Add(int.Parse(Console.ReadLine()!));
}
sg.Sort();

for (int i = 1; i <= 2 * n; i++)
{
    if (!sg.Contains(i))
    {
        gs.Add(i);
    }
}
gs.Sort();

int top = MAX;
while (sg.Count > 0 && gs.Count > 0)
{
    int id;

    //상근이 차례
    if (top == MAX)
    {
        top = sg[0];
        sg.RemoveAt(0);
    }
    else if ((id = FindSmallestLargerThan(sg, top)) != -1)
    {
        top = sg[id];
        sg.RemoveAt(id);
    }
    else
    {
        top = MAX;
    }

    if(sg.Count <= 0)
    {
        break;
    }

    //근상이 차례
    if (top == MAX)
    {
        top = gs[0];
        gs.RemoveAt(0);
    }
    else if ((id = FindSmallestLargerThan(gs, top)) != -1)
    {
        top = gs[id];
        gs.RemoveAt(id);
    }
    else
    {
        top = MAX;
    }

}

Console.WriteLine($"{gs.Count}\n{sg.Count}");

int FindSmallestLargerThan(List<int> list, int target)
{
    for(int i = 0; i < list.Count; i++)
    {
        if (list[i] > target)
        {
            return i;
        }
    }

    return -1;
}