char[] cam = {'C', 'A', 'M', 'B', 'R', 'I', 'D', 'G', 'E'};

string input = Console.ReadLine();
string result = new string(input.Where(c => !cam.Contains(c)).ToArray());

Console.WriteLine(result);