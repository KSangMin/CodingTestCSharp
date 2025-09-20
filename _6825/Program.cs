float w = float.Parse(Console.ReadLine()!);
float h = float.Parse(Console.ReadLine()!);

float bmi = w / h / h;

if(bmi < 18.5f) Console.WriteLine("Underweight");
else if(bmi <= 25.0f) Console.WriteLine("Normal weight");
else Console.WriteLine("Overweight");