Console.ReadLine();

int[] Ns = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] Ms = Console.ReadLine().Split().Select(int.Parse).ToArray();

long ans = Ns.Sum();

foreach(int m in Ms) if(m > 1) ans *= m;

Console.WriteLine(ans);