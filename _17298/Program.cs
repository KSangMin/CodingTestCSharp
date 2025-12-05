int n = int.Parse(Console.ReadLine()!);

int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Stack<int> st = new();

for(int i = 0; i < n; i++)
{
    while(st.Count > 0 && arr[st.Peek()] < arr[i])
    {
        arr[st.Pop()] = arr[i];
    }
    st.Push(i);
}

while(st.Count > 0)
{
    arr[st.Pop()] = -1;
}

Console.WriteLine(string.Join(" ", arr));