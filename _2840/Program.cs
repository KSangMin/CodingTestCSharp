using System.Text;

int[] nk = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];

char[] roll = new char[n];
bool[] check = new bool[26];

int i = 0;
for(int j = 0; j < k; j++)
{
    string[] each = Console.ReadLine()!.Split();

    int count = int.Parse(each[0]);
    char c = each[1][0];

    i = (i + count) % n;
    if((roll[i] != '\0' && roll[i] != c) // 같은 칸에 다른 문자를 넣으려는 경우
        || (roll[i] == '\0' && check[c - 'A'])) // 이미 다른 칸에 같은 문자가 있는 경우
    {
        Console.WriteLine("!");
        return;
    }
    roll[i] = c;
    check[c - 'A'] = true;
}

StringBuilder sb = new();
for(int j = 0; j < n; j++)
{
    char c = roll[(i - j + n) % n];
    sb.Append(c == '\0' ? '?' : c);
}

Console.WriteLine(sb.ToString());