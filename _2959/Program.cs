List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
nums.Sort();

Console.WriteLine(nums[0] * nums[2]);