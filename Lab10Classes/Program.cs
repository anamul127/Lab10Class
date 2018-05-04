using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet();
            int count = 0;
            bool go = true;
            while (go)
            {
                count++;

                Console.Write("Enter a radius: ");
                string Radius = Console.ReadLine();
                bool convert = double.TryParse(Radius, out double radius);
                Circle circleOne = new Circle(radius);

                Console.WriteLine("Circumfrence:");
                Console.WriteLine(circleOne.CalculateFormattedCircumference());
                Console.WriteLine();
                Console.WriteLine("Area:");
                Console.WriteLine(circleOne.CalculateFormattedArea());
                
                Console.WriteLine("Would you like to test another circle?(y/n)");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    go = true;
                }
                else
                {
                    Console.WriteLine($"Goodbye! You have created {count} object circles.");
                    go = false;
                }
            }
        }
        static void Greet()
        {

            Console.WriteLine("Welcome to the Circle Tester!");
        }
    }
}
