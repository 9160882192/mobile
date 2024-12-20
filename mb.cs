using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        char op = Console.ReadLine()[0];

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/': result = num2 != 0 ? num1 / num2 : double.NaN; break;
            default: Console.WriteLine("Invalid operator!"); return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
