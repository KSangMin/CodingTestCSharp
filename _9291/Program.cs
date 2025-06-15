int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    int[][] sudoku = new int[9][];

    for (int j = 0; j < 9; j++)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) input = Console.ReadLine();
        int[] line = input.Split().Select(int.Parse).ToArray();
        sudoku[j] = line;
    }

    if(isValidSudoku(sudoku)) Console.WriteLine($"Case {i + 1}: CORRECT");
    else Console.WriteLine($"Case {i + 1}: INCORRECT");

}

bool isValidSudoku(int[][] sudoku)
{
    //가로 체크
    for (int i = 0; i < 9; i++)
    {
        if (!isValid(sudoku[i]))
        {
            return false;
        }
    }
    //세로 체크
    for (int j = 0; j < 9; j++)
    {
        int[] column = new int[9];
        for (int k = 0; k < 9; k++)
        {
            column[k] = sudoku[k][j];
        }
        if (!isValid(column))
        {
            return false;
        }
    }
    //3x3 체크
    for (int row = 0; row < 9; row += 3)
    {
        for (int col = 0; col < 9; col += 3)
        {
            int[] block = new int[9];
            int index = 0;
            for (int r = row; r < row + 3; r++)
            {
                for (int c = col; c < col + 3; c++)
                {
                    block[index++] = sudoku[r][c];
                }
            }
            if (!isValid(block))
            {
                return false;
            }
        }
    }
    return true;
}

bool isValid(int[] line)
{
    bool[] check = new bool[10];

    foreach(int num in line)
    {
        if (num < 1 || num > 9 || check[num])
        {
            return false;
        }
        check[num] = true;
    }

    return true;
}