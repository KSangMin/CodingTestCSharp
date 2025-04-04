string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

string[] splits = Console.ReadLine().Split();
int[] scores = new int[n];

for(int i = 0; i < n; i++)
{
    scores[i] = int.Parse(splits[i]);
}

Array.Sort(scores);

Console.WriteLine(scores[n - (k)]);