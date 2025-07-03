int n = int.Parse(Console.ReadLine());

List<int> st = new List<int>();
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

st.Add(1);
for(int i = 2; i <= n; i++)
{
    st.Insert((int)MathF.Max(0, i - nums[i - 1] - 1), i);
}

Console.WriteLine(string.Join(' ', st));