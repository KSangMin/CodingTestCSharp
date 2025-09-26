using System.Linq;
using System.Text;

Dictionary<string, string> TXTMSG = new()
{
    { "CU", "see you" },
    { ":-)", "I’m happy" },
    { ":-(", "I’m unhappy" },
    { ";-)", "wink" },
    { ":-P", "stick out my tongue" },
    { "(~.~)", "sleepy" },
    { "TA", "totally awesome" },
    { "CCC", "Canadian Computing Competition" },
    { "CUZ", "because" },
    { "TY", "thank-you" },
    { "YW", "you’re welcome" },
    { "TTYL", "talk to you later" },
};

StringBuilder sb = new();

while (true)
{
    string input = Console.ReadLine()!;

    sb.AppendLine(TXTMSG.ContainsKey(input) ? TXTMSG[input] : input);

    if (input == "TTYL")
    {
        break;
    }
}

Console.WriteLine(sb.ToString());