int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = input[0], m  = input[1];

Console.WriteLine(n * 100 >= m ? "Yes" : "No");