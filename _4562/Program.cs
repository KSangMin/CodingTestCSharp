int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[] brains = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (brains[0] >= brains[1]) Console.WriteLine("MMM BRAINS");
    else Console.WriteLine("NO BRAINS");
}