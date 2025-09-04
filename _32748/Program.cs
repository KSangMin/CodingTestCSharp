using System.Text;

char[] digit = Console.ReadLine().Replace(" ", "").ToCharArray();

Dictionary<char, char> query = new();
Dictionary<char, char> backQuery = new();
for (int i = 0; i < 10; i++)
{
    query[(char)('0' + i)] = digit[i];
    backQuery[digit[i]] = (char)('0' + i);
}

string[] AB = Console.ReadLine().Split();

string fa = AB[0], fb = AB[1];
StringBuilder sb = new();
for (int i = 0; i < fa.Length; i++)
{
    sb.Append(backQuery[fa[i]]);
}
fa = sb.ToString();
sb.Clear();
for (int i = 0; i < fb.Length; i++)
{
    sb.Append(backQuery[fb[i]]);
}
fb = sb.ToString();
string sum = (int.Parse(fa) + int.Parse(fb)).ToString();

StringBuilder result = new();
foreach (char c in sum)
{
    result.Append(query[c]);
}

Console.WriteLine(result.ToString());