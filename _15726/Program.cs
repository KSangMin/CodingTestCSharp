double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

double ans = nums[0];
if (nums[1] < nums[2]) ans = ans / nums[1] * nums[2];
else ans = ans * nums[1] / nums[2];

Console.WriteLine((int)ans);