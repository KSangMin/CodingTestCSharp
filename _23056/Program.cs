using System.Text;

int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

List<Student> st = new();
while (true)
{
    string[] app = Console.ReadLine()!.Split();
    if(app[0] == "0" && app[1] == "0")
    {
        break;
    }

    st.Add(new Student(int.Parse(app[0]), app[1]));
}

List<Student> blue = new();
List<Student> white = new();
int[] gradeCount = new int[n + 1];

foreach (Student s in st)
{
    if(gradeCount[s.grade] >= m)
    {
        continue;
    }
    gradeCount[s.grade]++;

    if (s.grade % 2 == 1)
    {
        blue.Add(s);
    }
    else
    {
        white.Add(s);
    }
}

blue = blue.OrderBy(s => s.grade)
    .ThenBy(s => s.name.Length)
    .ThenBy(s => s.name)
    .ToList();
white = white.OrderBy(s => s.grade)
    .ThenBy(s => s.name.Length)
    .ThenBy(s => s.name)
    .ToList();

StringBuilder sb = new();
foreach (Student s in blue)
{
    sb.AppendLine($"{s.grade} {s.name}");
}
foreach (Student s in white)
{
    sb.AppendLine($"{s.grade} {s.name}");
}

Console.Write(sb.ToString());

class Student
{
    public int grade;
    public string name;

    public Student(int grade, string name)
    {
        this.grade = grade;
        this.name = name;
    }
}