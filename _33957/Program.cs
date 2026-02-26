int n = int.Parse(Console.ReadLine()!);

int[] accMinSum = new int[n];
int[] accMaxSum = new int[n];

for(int i = 0; i < n; i++)
{
    int[] mm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    accMinSum[i] += mm[0];
    accMaxSum[i] += mm[1];
    if (i > 0)
    {
        accMinSum[i] += accMinSum[i - 1];
        accMaxSum[i] += accMaxSum[i - 1];
    }
}

int count = 0;

int[] second = new int[2];
for(int i = 0; i < n - 1; i++)
{
    second[0] = accMinSum[n - 1] - accMinSum[i];
    second[1] = accMaxSum[n - 1] - accMaxSum[i];

    if(accMaxSum[i] >= second[0] && accMinSum[i] <= second[1])
    {
        count++;
    }
}

Console.WriteLine(count);