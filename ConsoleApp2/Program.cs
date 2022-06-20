// See https://aka.ms/new-console-template for more information
using CalculatorLib;
CalculateOperations operations = new CalculateOperations();
int ra = operations.Add(10, 10);
int rs = operations.Sub(10, 10);
int rm = operations.Mul(10, 10);
int rd = operations.Div(10, 10);
Console.WriteLine("Addition: "+ra);
Console.WriteLine("Subtraction: "+rs);
Console.WriteLine("Multiplication: " + rm);
Console.WriteLine("Division: " + rd);
Console.ReadLine();

