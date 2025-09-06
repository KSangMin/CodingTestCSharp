int[] n1212 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n1 = n1212[0], n2 = n1212[1], n12 = n1212[2];

Console.WriteLine((int)((n1 + 1) * (n2 + 1) / (n12 + 1)) - 1);