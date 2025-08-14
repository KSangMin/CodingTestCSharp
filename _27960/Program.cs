int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int A = AB[0], B = AB[1];

Console.WriteLine(A ^ B);