using System.Text;

string[] sk = Console.ReadLine()!.Split(' ').ToArray();

string s = sk[0].ToUpper();
int k = int.Parse(sk[1]);

HashSet<char> appeared = new();
StringBuilder sb = new();

int i = 0;
while(i < s.Length)
{
    char cur = s[i];
    int count = 0;

    int j = i;
    while(j < s.Length && s[j] == cur)
    {
        count++;
        j++;
    }

    if(!appeared.Contains(cur))
    {
        appeared.Add(cur);
        sb.Append(count >= k ? 1 : 0);
    }

    i = j;
}


Console.WriteLine(sb.ToString());