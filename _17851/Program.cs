int[] su = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int[] us = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

Array.Sort(su);
Array.Sort(us);

int count = 0;
for (int i = 0; i < su.Length; i++)
{
    if (su[i] > us[i])
    {
        count++;
    }
}

Console.WriteLine(count);