int[] nk = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];
int[] problem = new int[n];
for(int i = 0; i < n; i++)
{
    problem[i] = int.Parse(Console.ReadLine()!);
}

PriorityQueue<int, int> q = new();
long sum = 0;
long time = 0;
int j = 0;
for(int i = 0; i < k; i++)
{
    q.Enqueue(problem[i], problem[i]);
}

while(j < n)
{
    sum += q.Peek() + time;
    time += q.Dequeue();

    if(j + k < n)
    {
        q.Enqueue(problem[j + k], problem[j + k]);
    }
    
    j++;
}

Console.WriteLine(sum);