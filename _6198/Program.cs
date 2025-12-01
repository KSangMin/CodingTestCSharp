int n = int.Parse(Console.ReadLine()!);

int count = 0;
Stack<int> st = new();
for (int i = 0; i < n; i++)
{
    int h = int.Parse(Console.ReadLine()!);

    while (st.Count > 0 && st.Peek() < h)
    {
        st.Pop();
    }

    count += st.Count;

    st.Push(h);
}

Console.WriteLine(count);