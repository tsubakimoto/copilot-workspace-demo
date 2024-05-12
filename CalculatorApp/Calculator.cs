using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public void PerformCalculation()
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter operation (+, -, *, /):");
            string operation = Console.ReadLine();

            try
            {
                double number1 = double.Parse(input1);
                double number2 = double.Parse(input2);
                double result;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            return;
                        }
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("🙅");
            }
        }
    }
}
