using System.Text;

const int N = 9;

char[,] sudoku = new char[N, N];

bool[, ] checkRow = new bool[N, N + 1];
bool[, ] checkCol = new bool[N, N + 1];
bool[, ] checkBox = new bool[N, N + 1];

List<(int y, int x)> zero = new();

for(int i = 0; i < N; i++)
{
    string line = Console.ReadLine()!;
    for(int j = 0; j < N; j++)
    {
        sudoku[i, j] = line[j];
        int num = sudoku[i, j] - '0';
        if(num != 0)
        {
            checkRow[i, num] = true;
            checkCol[j, num] = true;
            checkBox[(i / 3) * 3 + (j / 3), num] = true;
        }
        else
        {
            zero.Add((i, j));
        }
    }
}

Solve(zero, checkRow, checkCol, checkBox, 0);

StringBuilder sb = new();
for (int i = 0; i < N; i++)
{
    for(int j = 0; j < N; j++)
    {
        sb.Append(sudoku[i, j]);
    }
    sb.AppendLine();
}

Console.Write(sb.ToString());

bool Solve(List<(int y, int x)> zero, bool[,] checkRow, bool[,] checkCol, bool[,] checkBox, int index)
{
    if (index == zero.Count)
    {
        return true;
    }

    var (y, x) = zero[index];
    int boxId = (y / 3) * 3 + (x / 3);
    for (int num = 1; num <= N; num++)
    {
        if (!checkRow[y, num] && !checkCol[x, num] && !checkBox[boxId, num])
        {
            sudoku[y, x] = (char)(num + '0');
            checkRow[y, num] = true;
            checkCol[x, num] = true;
            checkBox[boxId, num] = true;
            
            if (Solve(zero, checkRow, checkCol, checkBox, index + 1))
            {
                return true;
            }

            sudoku[y, x] = '0';
            checkRow[y, num] = false;
            checkCol[x, num] = false;
            checkBox[boxId, num] = false;
        }
    }

    return false;
}