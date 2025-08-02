using System.Text;

int T = int.Parse(Console.ReadLine());

StringBuilder sb = new();

for(int i = 0; i < T; i++)
{
    int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int turnLen = NM[0], XYLen = NM[1];
    int X = int.Parse(Console.ReadLine().Replace(" ", ""));
    int Y = int.Parse(Console.ReadLine().Replace(" ", ""));

    string allTurn = Console.ReadLine().Replace(" ", "");

    int count = 0;
    for(int j = 0; j < turnLen; j++)
    {
        int result = allTurn[j] - '0';
        for(int k = 1; k < XYLen; k++)
        {
            result = result * 10 + allTurn[(j + k) % turnLen] - '0';
        }

        if(X <= result && result <= Y)
        {
            count++;
        }
    }

    sb.AppendLine(count.ToString());
}

Console.Write(sb);