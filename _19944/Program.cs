int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = input[0];
int m = input[1];

string ans;
if (m <= 2) ans = "NEWBIE!";
else if (m <= n) ans = "OLDBIE!";
else ans = "TLE!";

Console.WriteLine(ans);