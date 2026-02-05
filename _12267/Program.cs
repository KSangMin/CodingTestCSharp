using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int _ = 0; _ < t; _++)
{
    int n = int.Parse(Console.ReadLine()!);

    sb.AppendLine($"Case #{_ + 1}: {(CheckSudoku(n) ? "Yes" : "No")}");
}

Console.Write(sb.ToString());

bool CheckSudoku(int n)
{
    int nP = n * n;
    int nS = nP * (nP + 1) / 2;
    List<List<int>> sudoku = new();

    for (int i = 0; i < nP; i++)
    {
        sudoku.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());
    }

    //가로세로
    for (int i = 0; i < nP; i++)
    {
        HashSet<int> row = new();
        HashSet<int> col = new();

        for (int j = 0; j < nP; j++)
        {
            int rNum = sudoku[i][j];
            int cNum = sudoku[j][i];

            if (rNum > nP || !row.Add(rNum))
            {
                return false;
            }

            if (cNum > nP || !col.Add(cNum))
            {
                return false;
            }
        }
    }

    //n*n
    for (int r = 0; r < nP; r += n)
    {
        for (int c = 0; c < nP; c += n)
        {
            HashSet<int> hs = new();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num = sudoku[r + i][c + j];

                    if (num > nP || !hs.Add(num))
                    {
                        return false;
                    }
                }
            }

            if (hs.Count < nP || hs.Sum() != nS)
            {
                return false;
            }
        }
    }

    return true;
}