int n = int.Parse(Console.ReadLine()!);
int[] col = new int[n + 1];

int count = 0;
FindQueen(0, col, ref count);
Console.WriteLine(count);

void FindQueen(int i, int[] col, ref int count)
{
    int n = col.Length - 1;

    if(Promising(i, col))
    {
        if(i == n)
        {
            count++;
        }
        else
        {
            for (int j = 1; j <= n; j++)
            {
                col[i + 1] = j;
                FindQueen(i + 1, col, ref count);
            }
        }
    }
}

bool Promising(int i, int[] col)
{
    for (int j = 1; j < i; j++)
    {
        if (col[i] == col[j] || Math.Abs(col[i] - col[j]) == Math.Abs(i - j))
            return false;
    }
    return true;
}