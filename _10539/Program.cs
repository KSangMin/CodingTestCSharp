int n = int.Parse(Console.ReadLine()!);

int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int[] answer = new int[n];
int[] accSum = new int[n];

answer[0] = accSum[0] = nums[0];
for (int i = 1; i < n; i++)
{
    answer[i] = nums[i] * (i + 1) - accSum[i - 1];
    accSum[i] = accSum[i - 1] + answer[i];
}

Console.WriteLine(string.Join(" ", answer));