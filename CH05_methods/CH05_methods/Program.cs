using System;

namespace CH05_methods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Write some methods");

            int nbr = GetInt("Enter a whole number: ");

            Console.WriteLine("Number entered = " + nbr);

            Console.WriteLine("sum 3 numbers = " + sum(1, 2, 3));
            Console.WriteLine("sum 2 numbers = " + sum(1, 2));







        }

        private static int GetInt(string prompt) {
            //accept input asa string
            int nbr = 0;
            bool success = false;
            while (!success) {
                //prompt the user for input 
                Console.Write(prompt);
                try {
                    string nbrStr = Console.ReadLine();
                    // convert that sting to an int
                    nbr = int.Parse(nbrStr);
                    success = true;

                } catch (Exception e) {
                    Console.WriteLine("Invalid # value");
                    Console.WriteLine(e.StackTrace);
                }
            }
            return nbr;
        }
        private static int sum(int n1, int n2, int n3 = 0) {
            int sum = n1 + n2 + n3;


            return sum;
        }

    }

}
