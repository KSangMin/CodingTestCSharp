int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[] aInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] bInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int[] aCardCnt = { 0, 0, 0, 0, 0 };
    int[] bCardCnt = { 0, 0, 0, 0, 0 };

    for(int j = 1; j < aInput.Length; j++)
    {
        aCardCnt[aInput[j]]++;
    }
    for (int j = 1; j < bInput.Length; j++)
    {
        bCardCnt[bInput[j]]++;
    }

    if (!Check(aCardCnt, bCardCnt)) Console.WriteLine("D");
}

bool Check(int[] aCardCnt, int[] bCardCnt)
{
    for (int j = 4; j >= 1; j--)
    {
        if (aCardCnt[j] > bCardCnt[j])
        {
            Console.WriteLine("A");
            return true;
        }
        else if (aCardCnt[j] < bCardCnt[j])
        {
            Console.WriteLine("B");
            return true;
        }
        else continue;
    }

    return false;
}