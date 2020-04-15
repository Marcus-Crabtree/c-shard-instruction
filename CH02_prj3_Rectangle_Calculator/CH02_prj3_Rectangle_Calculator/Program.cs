using System;

namespace CH02_prj3_Rectangle_Calculator {
    class Program {
        static void Main(string[] args) {
            int length = 0;
            int width = 0;
            string choice = "y";


            while (choice.Contains("y")) {
                Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
                Console.WriteLine();
                Console.WriteLine("Enter length: ");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Area: " + (length * width));
                Console.WriteLine("Perimeter: "+(2*(width)+2*(length)));
                Console.WriteLine();
                Console.WriteLine("Press 'y' to continue or 'n' to exit: ");
                choice = Console.ReadLine();



            }
        }

    }
}

