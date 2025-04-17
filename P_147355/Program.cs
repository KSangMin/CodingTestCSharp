string t = "3141592";
string p = "271";

int answer = 0;

for(int i = 0; i <= t.Length - p.Length; i++)
{
    string sub = t.Substring(i, p.Length);

    if (sub.CompareTo(p) <= 0) answer++;
}

return answer;