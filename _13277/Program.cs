int T = int.Parse(Console.ReadLine());
for(int i = 0; i < T; i++)
{
    int[] VE = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine(2 - VE[0] + VE[1]);
}