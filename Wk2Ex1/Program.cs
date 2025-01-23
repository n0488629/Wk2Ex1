using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for numerical grade
            Console.Write("What is a numeric score (0 to 100)? ");
            // Convert user input to double variable
            double grade = Convert.ToDouble(Console.ReadLine());

            // Start switch with variable grade
switch (grade)

{
    // assigns grade to variable i, then compared to letter scale
    case double i when i >= 89.5:
        // Print out letter and numerical grade on screen
        Console.WriteLine("The letter grade for score " + grade + " is: A");
        // Force exits the case/switch
        break;

    // assigns grade to variable i, then compared to letter scale
    case double i when i >= 79.5:
        // Print out letter and numerical grade on screen
        Console.WriteLine("The letter grade for score " + grade + " is: B");
        // Force exits the case/switch
        break;

    // assigns grade to variable i, then compared to letter scale
    case double i when i >= 69.5:
        // Print out letter and numerical grade on screen
        Console.WriteLine("The letter grade for score " + grade + " is: C");
        // Force exits the case/switch
        break;

    // assigns grade to variable i, then compared to letter scale
    case double i when i >= 59.5:
        // Print out letter and numerical grade on screen
        Console.WriteLine("The letter grade for score " + grade + " is: D");
        // Force exits the case/switch
        break;

    // default option if no cases are true
    default:
        // Print out letter and numerical grade on screen
        Console.WriteLine("The letter grade for score " + grade + " is: F");
        // Force exits the case/switch
        break;
}
// Pause screen for user
Console.ReadLine();

        }
    }
}
