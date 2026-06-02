using System;

// This namespace groups the classes in this console application together.
namespace TheTechAcademyBasicCSharpProjects
{
    // This class contains a method that accepts two integer values.
    class MathOperations
    {
        // This void method takes two integers as parameters.
        // It performs a math operation on the first integer and displays the second integer.
        public void DoMath(int firstNumber, int secondNumber)
        {
            // This variable stores the result of multiplying the first integer by 2.
            int result = firstNumber * 2;

            // This line displays the result of the math operation performed on the first integer.
            Console.WriteLine("The result of doubling the first number is: " + result);

            // This line displays the second integer to the screen.
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    // This class contains the Main method, which is the entry point of the console application.
    class Program
    {
        // This is the main method where the program begins execution.
        static void Main(string[] args)
        {
            // This line creates an instance of the MathOperations class.
            MathOperations mathOperations = new MathOperations();

            // This line calls the method using positional arguments.
            mathOperations.DoMath(10, 20);

            // This blank line makes the console output easier to read.
            Console.WriteLine();

            // This line calls the method again, this time using named arguments.
            mathOperations.DoMath(firstNumber: 15, secondNumber: 30);

            // This line waits for the user to press a key before the console window closes.
            Console.ReadKey();
        }
    }
}
