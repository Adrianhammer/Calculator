using System.Text.RegularExpressions;
using CalculatorLibrary;
namespace CalculatorProgram;
class Program
{

    static void Main(string[] args)
    {

        bool endApp = false;
        Calculator calculator = new Calculator();

        // Display title as the C# console calculator app
        System.Console.WriteLine("Hi and Welcome to the Console calculator\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declare variables and set them to empty
            // Use Nullable types (with ?) to math the type of console.readline
            string? numInput1 = "";
            string? numInput2 = "";
            double result = 0;

            //Ask the user to type the first number
            System.Console.WriteLine($"You have done {Counter.Count} calculations");
            Console.WriteLine("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.WriteLine("This is not a valid input. Please input a numeric value");
                numInput1 = Console.ReadLine();
            }

            // Ask the user to type the second number
            Console.WriteLine("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.WriteLine("This is not a valid input. Please input a numeric value");
                numInput2 = Console.ReadLine();
            }

            // Ask the user to choose an operation
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - add");
            Console.WriteLine("\ts - subtract");
            Console.WriteLine("\tm - multiply");
            Console.WriteLine("\td - divide");

            string? operation = Console.ReadLine();

            // Validate input is not null, and mathes the pattern
            if (operation == null || !Regex.IsMatch(operation, "[a|s|m|d]"))
            {
                Console.WriteLine("Error: Unrecognized input.");
            }
            else
            {
                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, operation);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occured trying to do the math.\n - Details: " + e.Message);
                }
            }
            Console.WriteLine("--------------------------------\n");

            // Wait for the user to respond before closing
            Console.WriteLine("Press 'n' and Enter to close the app or press any other key and Enter to continue");
            if (Console.ReadLine() == "n") 
            {
                Counter.reset();
                endApp = true;
            }

            Counter.increment();
            Console.WriteLine("\n"); // Friendly linespacing
        }
        return;
    }
}
