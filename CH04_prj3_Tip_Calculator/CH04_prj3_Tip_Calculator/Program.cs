using System;

namespace CH04_prj3_Tip_Calculator {
    class Program {
        static void Main(string[] args) {
            double mealCost = 0.0;
            string choice = "y";
            double rate = 0.0;
            double tipAmount = 0.0; //mealCost + rate;
            double mealCostFinal = 0.0; // mealCost + tipAmount;
            Console.WriteLine("Tip Calculator");
            Console.WriteLine();
            while (choice.Contains("y")) {
                Console.WriteLine("please enter the cost of meal: ");
                mealCost = Convert.ToDouble(Console.ReadLine());
                /*
                for (rate = .15; rate < .30; rate += .05)
                {
                    tipAmount = mealCost * rate;
                    mealCostFinal = mealCost + tipAmount;
                }
                */
                for (rate = 0.15; rate <= 0.25; rate += 0.05) //0.15, 0.20, 0.25
                {
                    tipAmount = rate * mealCost;
                    mealCostFinal = tipAmount + mealCost;
                    Console.WriteLine(rate);
                    Console.WriteLine("Tip amount: " + tipAmount);
                    Console.WriteLine("Total amount: " + mealCostFinal);
                }
                //Console.WriteLine (rate + tipAmount + mealCostFinal);
                Console.Write("would you like to calculate another tip? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Goodbye!")
        }
    }
}
