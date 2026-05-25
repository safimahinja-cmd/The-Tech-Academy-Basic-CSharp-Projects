using System; // Imports the System namespace so the program can use Console methods and basic data conversion tools.

// Defines the main Program class that contains the application's entry point.
class Program
{
    // The Main method is where the console application begins execution.
    static void Main()
    {
        // Displays the required welcome message to the user when the program starts.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Asks the user to enter the package weight.
        Console.WriteLine("Please enter the package weight:");

        // Reads the user's input from the console and converts it to a decimal value for calculation.
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Checks whether the package weight is over the allowed limit.
        if (weight > 50)
        {
            // Displays the required message if the package is too heavy to ship.
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            // Ends the program immediately because no further processing is needed.
            return;
        }

        // Asks the user to enter the package width.
        Console.WriteLine("Please enter the package width:");

        // Reads the package width from the console and converts it to a decimal value.
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Asks the user to enter the package height.
        Console.WriteLine("Please enter the package height:");

        // Reads the package height from the console and converts it to a decimal value.
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Asks the user to enter the package length.
        Console.WriteLine("Please enter the package length:");

        // Reads the package length from the console and converts it to a decimal value.
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Adds the width, height, and length together to determine whether the package is too large.
        decimal dimensionTotal = width + height + length;

        // Checks whether the total of the dimensions is greater than the allowed maximum.
        if (dimensionTotal > 50)
        {
            // Displays the required message if the package is too large to ship.
            Console.WriteLine("Package too big to be shipped via Package Express.");

            // Ends the program immediately because the package cannot be processed further.
            return;
        }

        // Calculates the shipping quote by multiplying the dimensions together, multiplying by the weight, and dividing by 100.
        decimal quote = (width * height * length * weight) / 100;

        // Displays the calculated shipping quote formatted as a dollar amount with two decimal places.
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Displays a closing thank-you message to the user.
        Console.WriteLine("Thank you!");
    }
}
