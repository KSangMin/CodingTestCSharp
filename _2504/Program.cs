string s = Console.ReadLine()!;

int ans = 0;
int temp = 1;
Stack<char> st = new();

for (int i = 0; i < s.Length; i++)
{
    char c = s[i];


    if (c == '(')
    {
        st.Push(c);
        temp *= 2;
    }
    else if (c == '[')
    {
        st.Push(c);
        temp *= 3;
    }

    else if (c == ')')
    {
        if (st.Count == 0 || st.Peek() != '(')
        {
            ans = 0;
            break;
        }
        if (s[i - 1] == '(')
        {
            ans += temp;
        }

        temp /= 2;
        st.Pop();
    }
    else if (c == ']')
    {
        if (st.Count == 0 || st.Peek() != '[')
        {
            ans = 0;
            break;
        }
        if (s[i - 1] == '[')
        {
            ans += temp;
        }
        temp /= 3;
        st.Pop();
    }
}

Console.WriteLine(st.Count() > 0 ? 0 : ans);