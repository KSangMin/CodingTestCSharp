int[] dx = {0, 1, 0, -1};
int[] dy = {1, 0, -1, 0};

int[,] grid = new int[5, 7]
{//답 7
    {3, 1, 3, 2, 3, 2, 1},
    {0, 1, 0, 1, 3, 3, 3},
    {0, 1, 0, 1, 3, 3, 3},
    {0, 2, 1, 2, 1, 1, 1},
    {0, 2, 3, 3, 1, 3, 2}
};
int n = 5, m = 7;
int[,] check = new int[n, m];

int answer = 0;
answer = GetBalloon(0, 0, 0, check);
Console.WriteLine(answer);

int GetBalloon(int x, int y, int curDir, int[,] check)
{
    int max = 0, result = 0;
    int[,] eachCheck = new int[n, m];
    Array.Copy(check, eachCheck, check.Length);

    while(0 <= x && x < n && 0 <= y && y < m)
    {
        int type = grid[x, y];

        if(type == 0)
        {
            break;
        }
        if (type == 1)
        {
            if(eachCheck[x, y] == 0)
            {
                result++;
                eachCheck[x, y] = 1;
            }
        }
        if(type == 2)
        {
            if (eachCheck[x, y] == 45)
            {
                switch(curDir)
                {
                    case 0:
                        curDir = 3;
                        break;
                    case 1:
                        curDir = 2;
                        break;
                    case 2:
                        curDir = 1;
                        break;
                    case 3:
                        curDir = 0;
                        break;
                }

                max = GetBalloon(x + dx[curDir], y + dy[curDir], curDir, eachCheck);
            }
            else if(eachCheck[x, y] == 135)
            {
                switch(curDir)
                {
                    case 0:
                        curDir = 1;
                        break;
                    case 1:
                        curDir = 0;
                        break;
                    case 2:
                        curDir = 3;
                        break;
                    case 3:
                        curDir = 2;
                        break;
                }

                max = max + GetBalloon(x + dx[curDir], y + dy[curDir], curDir, eachCheck);
            }
            else
            {
                eachCheck[x, y] = (curDir % 2 == 0) ? 135 : 45;
                int nextDir = (curDir + 1) % 4;
                int value1 = GetBalloon(x + dx[nextDir], y + dy[nextDir], nextDir, eachCheck);
                eachCheck[x, y] = (curDir % 2 == 0) ? 45 : 135;
                nextDir = (curDir + 3) % 4;
                int value2 = GetBalloon(x + dx[nextDir], y + dy[nextDir], nextDir, eachCheck);

                max = Math.Max(value1, value2);
            }
        }
        else if(type == 3)
        {
            
        }

        x += dx[curDir];
        y += dy[curDir];
    }

    result += max;

    return result;
}