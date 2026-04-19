using System.Text;

const int MAX = 1000000;

int n = int.Parse(Console.ReadLine()!);
int[] player = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
bool[] exist = new bool[MAX + 1];
foreach(int p in player)
{
    exist[p] = true;
}

int[] score = new int[MAX + 1];
foreach(int p in player)
{
    for(int i = p * 2; i <= MAX; i += p)
    {
        if (exist[i])
        {
            score[i]--;
            score[p]++;
        }
    }
}

StringBuilder sb = new();
foreach(int p in player)
{
    sb.Append(score[p]).Append(' ');
}
Console.WriteLine(sb.ToString());