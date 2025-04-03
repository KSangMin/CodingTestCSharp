int month = int.Parse(Console.ReadLine());
int day = int.Parse(Console.ReadLine());

if (month < 2 || (month == 2 && day < 18)) Console.WriteLine("Before");
else if (month == 2 && day == 18) Console.WriteLine("Special");
else Console.WriteLine("After");