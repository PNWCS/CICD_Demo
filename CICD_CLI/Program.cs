// See https://aka.ms/new-console-template for more information
using CICD_Core;


Console.WriteLine("Enter First NUmber:");
int a =int.Parse(Console.ReadLine());

Console.WriteLine("Enter Second Number:");
int b= int.Parse(Console.ReadLine());

double result = Calculator.Divide(a, b);

Console.WriteLine($"{a}/{b}={result}");