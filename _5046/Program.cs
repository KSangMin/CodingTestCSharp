int[] NBHW = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = NBHW[0], B = NBHW[1], H = NBHW[2], W = NBHW[3];

int min = 500001;
for(int i = 0; i < H; i++)
{
    int cost = int.Parse(Console.ReadLine());
    int[] people = Console.ReadLine().Split().Select(int.Parse).ToArray();
    
    int total = cost * N;
    if (total > B) continue;

    foreach(int p in people)
    {
        if(p >= N)
        {
            min = Math.Min(min, total);
            break;
        }
    }
}

Console.WriteLine(min == 500001 ? "stay home" : min);