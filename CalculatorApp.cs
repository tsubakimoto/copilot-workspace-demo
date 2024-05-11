using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App in C# for .NET 8");
            Console.WriteLine("Please enter the operation to perform (+, -, *, /):");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the first number:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("🙅");
                return;
            }

            Console.WriteLine("Enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("🙅");
                return;
            }

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("🙅");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("🙅");
                    break;
            }
        }
    }
}
