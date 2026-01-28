using System;
using System.Text;

string n = Console.ReadLine()!;
if (n == "1" || n == "2")
{
    Console.WriteLine(n);
}
else
{
    Console.WriteLine(Double(MinusOne(n)));
}

string Double(string n)
{
    List<char> result = new();

    int carry = 0;

    for (int i = n.Length - 1; i >= 0; i--)
    {
        int value = (n[i] - '0') * 2 + carry;
        result.Add((char)('0' + (value % 10)));
        carry = value / 10;
    }

    if (carry > 0)
        result.Add((char)('0' + carry));

    result.Reverse();

    return new string(result.ToArray());
}

string MinusOne(string n)
{
    List<char> result = n.ToList();

    int i = result.Count - 1;
    while(i >= 0)
    {
        result[i] = (char)(result[i] - 1);
        if (result[i] < '0')
        {
            result[i] = '9';
        }
        else
        {
            break;
        }

        i--;
    }

    return new string(result.ToArray()).TrimStart('0');
}