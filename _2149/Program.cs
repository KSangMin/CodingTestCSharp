using System.Text;

string key = Console.ReadLine()!;
string code = Console.ReadLine()!;
int len = key.Length;
int row = code.Length / len;
string[] part = new string[len];
for(int i = 0; i < len; i++)
{
    part[i] = code.Substring(i * row, row);
}

char[] decode = key.ToCharArray();
Array.Sort(decode);
int[] idx = new int[len];
bool[] check = new bool[len];
for(int i = 0;i < len; i++)
{
    for(int j = 0; j < len; j++)
    {
        if (key[i] == decode[j] && !check[j])
        {
            idx[i] = j;
            check[j] = true;
            break;
        }
    }
}

StringBuilder sb = new();
for(int i = 0; i < row; i++)
{
    for(int j = 0; j < len; j++)
    {
        sb.Append(part[idx[j]][i]);
    }
}

Console.WriteLine(sb.ToString());