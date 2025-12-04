
using System;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Sample Console App!");

            // Ask for user's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Let's do a quick calculation.");

            // Ask for two numbers
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calculate sum
            int sum = num1 + num2;

            int sub = num1 - num2;

            // Display result
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");

            Console.WriteLine($"The sub of {num1} and {num2} is: {sub}");



            // Wait before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
