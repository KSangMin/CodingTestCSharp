int[] V = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] L = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] H = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

long vVar = V[0] * V[1];
long lVar = L[0] * L[1];
long hVar = H[0] * H[1] * H[2];

Console.WriteLine((vVar + lVar) * hVar);