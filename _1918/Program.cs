string pre = Console.ReadLine()!;

List<char> post = new();
Stack<char> st = new();
foreach (char c in pre)
{
    switch (c)
    {
        case '*':
        case '/':
            while (st.Count > 0)
            {
                if (st.Peek() == '*' || st.Peek() == '/')
                {
                    post.Add(st.Pop());
                }
                else
                {
                    break;
                }
            }
            st.Push(c);
            break;
        case '+':
        case '-':
            while (st.Count > 0)
            {
                if (st.Peek() == '*' || st.Peek() == '/'
                    || st.Peek() == '+' || st.Peek() == '-')
                {
                    post.Add(st.Pop());
                }
                else
                {
                    break;
                }
            }
            st.Push(c);
            break;
        case '(':
            st.Push(c);
            break;
        case ')':
            while (st.Count > 0)
            {
                if (st.Peek() == '(')
                {
                    st.Pop();
                    break;
                }
                else
                {
                    post.Add(st.Pop());
                }
            }
            break;
        default:
            post.Add(c);
            break;
    }
}

while(st.Count > 0)
{
    post.Add(st.Pop());
}

Console.WriteLine(string.Join("", post));