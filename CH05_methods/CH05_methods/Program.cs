using System;

namespace CH05_methods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Write some methods");

            int nbr = GetInt();

            Console.WriteLine("Number entered = " + nbr);









        }

        private static int GetInt() {
            //prompt the user for input 
            Console.Write("Enter a whole number: ");
            //accept input asa string
            string nbrStr = Console.ReadLine();
            // convert that sting to an int
            int nbr = int.Parse(nbrStr);
            return nbr;
        }
    }
}
