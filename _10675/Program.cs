int[] abn = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int a = abn[0], b = abn[1], n = abn[2];

int min = 1001;
for(int i = 0; i < n; i++)
{
    int[] pc = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int price = pc[0], c = pc[1];

    int[] course = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int id = -1;
    for(int j = 0; j < c; j++)
    {
        if (course[j] == a)
        {
            id = j;
            break;
        }
    }

    if(id == -1)
    {
        continue;
    }

    for (int j = id + 1; j < c; j++)
    {
        if (course[j] == b)
        {
            min = Math.Min(min, price);
            break;
        }
    }
}

Console.WriteLine(min > 1000 ? -1 : min);