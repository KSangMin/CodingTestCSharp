int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int t = int.Parse(Console.ReadLine());

int sum = nums[0];
t -= 30;
if (t > 0) { sum += t / nums[1] * nums[2]; t %= nums[1]; }
if (t > 0) sum += nums[2]; 

Console.WriteLine(sum);