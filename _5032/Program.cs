int[] efc = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int e = efc[0] + efc[1], c = efc[2];

int sum = 0;
while(e >= c)
{
    sum += e / c;
    e = e / c + e % c;
}

Console.WriteLine(sum);