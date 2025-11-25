int n = int.Parse(Console.ReadLine()!);
List<int> nums = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

Console.WriteLine(nums.Min() * nums.Max());