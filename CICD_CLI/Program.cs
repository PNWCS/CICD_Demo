using CICD_Core;
Console.WriteLine("Enter the first Number");
int a, b;
while (true)
{
    string? s = Console.ReadLine();
    if (!int.TryParse(s, out a))
    {
        Console.WriteLine("Enter a integer");
    }
    else
    {
        break;
    }
}
Console.WriteLine("Enter the second Number");
while (true)
{
    string? s = Console.ReadLine();
    if (!int.TryParse(s, out b))
    {
        Console.WriteLine("Enter a integer");
    }
    else
    {
        break;
    }
}
double d = Calculator.Divide(a, b);
Console.WriteLine($"{a} / {b} = {d}");