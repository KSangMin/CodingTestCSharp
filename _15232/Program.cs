using System.Text;

int r = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

string s = new('*', c);

for (int i = 0; i < r; i++)
{
    Console.WriteLine(s);
}