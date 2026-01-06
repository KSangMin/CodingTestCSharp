char[] a = Console.ReadLine()!.ToCharArray();
char op = Console.ReadLine()![0];
char[] b = Console.ReadLine()!.ToCharArray();

string ans;
if(op == '+')
{
    if(a.Length == b.Length)
    {
        a[0] = '2';
        ans = new string(a);
    }
    else if(a.Length > b.Length)
    {
        a[a.Length - b.Length] = '1';
        ans = new string(a);
    }
    else
    {
        b[b.Length - a.Length] = '1';
        ans = new string(b);
    }
}
else
{
    ans = '1' + new string('0', a.Length + b.Length - 2);
}

Console.WriteLine(ans);