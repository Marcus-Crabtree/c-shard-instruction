using System;

namespace CH03_Data_Types {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Lets play with some data types!");

            double d1 = 55.77;
            double d2 = 11.34;


            double diff = d1 - d2;
            Console.WriteLine(diff);

            // compound assignemnt operators
            int n1 = 5;
            n1 += 7;
            n1 -= 2;
            n1 *= 3;
            Console.WriteLine(n1);

            //unary operators
            n1++;
            Console.WriteLine(n1);

            //random number
            Random random = new Random();
            int rand1 = random.Next();
            Console.WriteLine("rand1 = " + rand1);
            int rand10 = random.Next(10);
            Console.WriteLine("rand1 = " + rand10);
            for (int i = 0; i < 100; i++) 
                rand10 = random.Next(10);
                Console.WriteLine("rand1 = " + rand10);
        
        int rand6 = random.Next(6) + 1;

            //currency
            double price1 = 199.5788888888;
            Console.WriteLine(price1.ToString("C2"));

            //percents -- rounding to 3 decimal places
            double rate1 = .035777777;
            Console.WriteLine(rate1.ToString("P3"));







        }
    }
}
