﻿// See https://aka.ms/new-console-template for more information
using CICD_Core;

Console.WriteLine("enter the first number:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("enter the second number:");
int b = int.Parse(Console.ReadLine());

double result = Calculator.Divide(a, b);

Console.WriteLine($"{a}/{b} = {result}");

