using System;               // Allows usage of classes from the System Name Space

namespace HelloWorld        // Used to organize code, container for classes and other name spaces
{
    class Program           // container for data and methods, functionality to program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");  // This is an comment

            double num = 12.9;      // standard types like other languages
            double num2 = 13.01;
            int num3 = 14;


            if (num > num2) {
                Console.WriteLine("x is greater than y"); // if else
            }

            else {
                Console.WriteLine("y is greater than x");
            }

            string result = (num3 > 15) ? "Yes" : "No";    // shorter version of if else for c#
            Console.WriteLine(result);


            Console.WriteLine(num < num3); // Bool
        }
    }
}