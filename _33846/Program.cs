int[] nt = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nt[0], t = nt[1];

int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Array.Sort(arr, 0, t);

Console.WriteLine(string.Join(" ", arr));