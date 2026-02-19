string phrase = "WelcomeToSMUPC";
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(phrase[(n - 1) % phrase.Length]);