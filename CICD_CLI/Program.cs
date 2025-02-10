using CICD_Core;

int a, b;

Console.WriteLine("Enter the numerator: ");
while (true)
{
    string? a1 = (Console.ReadLine());
    if (!int.TryParse(a1, out a))
    {
        Console.WriteLine("Please enter an integer!");
    }
    else break;
}


Console.WriteLine("Enter the denominator: ");
while (true)
{
    string? b1 = (Console.ReadLine());
    if (!int.TryParse(b1, out b))
    {
        Console.WriteLine("Please enter an integer!");
    }
    else break;
}


double result = Calculator.Divide(a, b);
Console.WriteLine($"The result of {a} / {b} = {result}");