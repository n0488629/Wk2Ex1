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

            switch (grade)
            {
                case double i when i >= 89.5:
                    Console.WriteLine("The letter grade for score " + grade + " is: A");
                    break;
                case double i when i >= 79.5:
                    Console.WriteLine("The letter grade for score " + grade + " is: B");
                    break;
                case double i when i >= 69.5:
                    Console.WriteLine("The letter grade for score " + grade + " is: C");
                    break;
                case double i when i >= 59.5:
                    Console.WriteLine("The letter grade for score " + grade + " is: D");
                    break;
                default:
                    Console.WriteLine("The letter grade for score " + grade + " is: F");
                    break;
            }
            Console.ReadLine();

        }
    }
}
