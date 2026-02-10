int[] V = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] L = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] H = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int vVar = V[0] * V[1];
int lVar = L[0] * L[1];
int hVar = H[0] * H[1] * H[2];

Console.WriteLine((vVar + lVar) * hVar);