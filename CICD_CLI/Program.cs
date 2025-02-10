using CICD_Core;

Console.WriteLine("Enter the first Number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second Number");
int b = int.Parse(Console.ReadLine());

double d = Calculator.Divide(a, b);
Console.WriteLine($"{a} / {b} = {d}");