using System.Text;

TextReader sr = Console.In;
string[] nq = sr.ReadLine().Split();
int n = int.Parse(nq[0]), q = int.Parse(nq[1]);

bool[] pc = new bool[n + 1];

StringBuilder sb = new();
for (int i = 0; i < q; i++)
{
    string[] query = sr.ReadLine().Split();
    int type = int.Parse(query[0]);

    switch (type)
    {
        case 1:
            int x = int.Parse(query[1]);
            if (!pc[x])
            {
                n--;
                pc[x] = true;
            }
            break;
        case 2:
            int y = int.Parse(query[1]);
            if (pc[y])
            {
                n++;
                pc[y] = false;
            }
            break;
        case 3:
            sb.AppendLine(n.ToString());
            break;
    }
}

Console.Write(sb.ToString());