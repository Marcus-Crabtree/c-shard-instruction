using System;

namespace CH03_prj1_Temperature_Converter {
    class Program {
        static void Main(string[] args) {
            string choice = "y";
            double tempF = 0.0;
            double tempC = 0.0;
            Console.WriteLine("Welcome to the Temperature Converter.");
            while (choice.Contains("y")) {
                Console.Write("Enter degrees in Fahrenheit: ");
                tempF = Convert.ToDouble(Console.ReadLine());
                tempC = (tempF - 32) * 5 / 9;

                Console.WriteLine("Degrees in Celsius: " + Math.Round(tempC, 2,MidpointRounding.ToEven));
                Console.Write("Press 'y' to continue, 'n' to exit: ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Good bye!");
        }
    }
}
