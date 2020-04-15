using System;

namespace CH07_Classes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create some products!");

            Product p1 = new Product("Java", "Murach's Java", 57.50);
            Product p2 = new Product(".net", "Murach's .net", 59.50);
            p2.Price = 49.99;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }


}







