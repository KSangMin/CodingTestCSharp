int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int price = int.Parse(Console.ReadLine());

int sum = input.Sum();
if (price * 2 <= sum) Console.WriteLine(sum - price * 2);
else Console.WriteLine(sum);