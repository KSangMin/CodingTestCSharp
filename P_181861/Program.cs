int[] arr = new int[] { };
List<int> answer = new();
foreach (int i in arr)
{
    for (int j = 0; j < i; j++)
    {
        answer.Add(i);
    }
}
