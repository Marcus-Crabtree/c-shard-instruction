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
            //prompt the user for input 
            Console.Write(prompt);
            //accept input asa string
            string nbrStr = Console.ReadLine();
            // convert that sting to an int
            int nbr = int.Parse(nbrStr);
            return nbr;
        }
   private static int sum(int n1, int n2, int n3=0) {
            int sum = n1+n2+n3;


            return sum;
        }
    
    }
}
