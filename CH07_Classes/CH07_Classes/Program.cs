using System;

namespace CH07_Classes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create some products!");

            Product p1 = new Product("Java", "Murach's Java", 57.50);
            Product p2 = new Product(".net", "Murach's .net", 59.50);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
    
    class Product {
        string Code;
        string Description;
        double Price;

        public Product() {
            Code = "";
            Description = "";
            Price = 0.0;
        }
        public Product(string code, string desc, double price) {
            this.Code = code;
            this.Description = desc;
            this.Price = price;
        }


        public override string ToString() {
            //return "Product: code="+Code+", desc = "+Description+", price="+Price;

            //interpollation ex - dollarsign infront of string and wrap var in curlies (not double quote
            return $"Product: code={Code}, desc={Description}, price={Price}";
        }

    }
}
