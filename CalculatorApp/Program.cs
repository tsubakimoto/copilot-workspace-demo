using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("You can perform arithmetic operations with two input values.");
            Console.WriteLine("Type 'exit' to close the app.");

            while (true)
            {
                calculator.PerformCalculation();
                Console.WriteLine("Would you like to perform another calculation? (yes/no)");
                string response = Console.ReadLine();
                if (response.ToLower() != "yes")
                {
                    break;
                }
            }
        }
    }
}
