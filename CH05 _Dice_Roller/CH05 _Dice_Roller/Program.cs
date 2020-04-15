using System;

namespace CH05__Dice_Roller {
    class Program {
        static void Main(string[] args) {
            int die1 =0;
            int die2 = 0;
            string choice = "y";
            int sumDice = 0;
            
            Console.WriteLine("Dice roller");
            while (choice.Contains("y")) {
                Random rnd = new Random();
                DiceRoll(out die1, out die2, rnd);
                sumDice = die1 + die2;
                Console.WriteLine("Total: " + sumDice);

                SpecialMessage(sumDice);

                Console.WriteLine("roll again? (y/n): ");
                choice = Console.ReadLine();

            }

            Console.WriteLine("Goodbye!");
        }

        private static void SpecialMessage(int sumDice) {
            if (sumDice == 12) {
                Console.WriteLine("boxcars!");
                Console.WriteLine();
            } else if (sumDice == 2) {
                Console.WriteLine("Snake eyes!");
                Console.WriteLine();
            }
        }

        private static void DiceRoll(out int die1, out int die2, Random rnd) {
            die1 = rnd.Next(1, 7);
            die2 = rnd.Next(1, 7);
            Console.WriteLine("Die 1: " + die1);
            Console.WriteLine("Die 2: " + die2);
            
        }
    }
}
