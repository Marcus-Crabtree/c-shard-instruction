using System;

namespace CH04_prj3_Tip_Calculator {
    class Program {
        static void Main(string[] args) {
            double mealCost = 0.0;
            string choice = "y";
            double rate = 0.0;
            double tipAmount = mealCost + rate;
            double mealCostFinal =mealCost+tipAmount;
            Console.WriteLine("Tip Calculator");
            Console.WriteLine();
            while (choice.Contains("y")) {
                Console.WriteLine("please enter the cost of meal: ");
                mealCost = Convert.ToDouble(Console.ReadLine());
                for (rate = .15; rate <.30; rate +=.05) {
                    tipAmount = mealCost * rate;
                    mealCostFinal = mealCost + tipAmount;
                }
                Console.WriteLine (rate + tipAmount + mealCostFinal);
                Console.Write("would you like to calculate another tip? (y/n): ");
                choice = Console.ReadLine();
               
            }

    Console.WriteLine("Goodbye!");
        }
    }
}
