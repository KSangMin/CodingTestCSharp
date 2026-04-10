int[] ns = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = ns[0], s = ns[1];
int[] arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int left = 0, right = 0;

int sum = arr[0];
int min = int.MaxValue;
while(min > 1 && left < n && right < n)
{
    if(sum < s)
    {
        right++;
        if(right < n)
        {
            sum += arr[right];
        }
    }
    else
    {
        min = Math.Min(min, right - left + 1);
        left++;
        sum -= arr[left - 1];
    }
}

Console.WriteLine(min == int.MaxValue ? 0 : min);