using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("abc");
            int n1 = 5;
            int n2 = 2;
            int n3;
            Int32 n4 = 11;
            //test single line comment
            /*
             * this 
             * is 
             * a
             * multiline/block comment */

            Console.WriteLine("Sum = " + (n1 + n2));

            double d1 = 5.7;
            double d2 = 54.2;
            Console.WriteLine("double sum: " + (d1 + d2));


            Console.WriteLine("Enter a whole number: ");
            n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered " + n4);
            if (n4 > 10) {
                Console.WriteLine("Your number is greater than 10");
            } else {
                Console.WriteLine(" your number is less than or equal to 10");
            }



            String choice = "y";
            while (choice.Contains("y")) {
                Console.WriteLine(" In the loop...");
                Console.WriteLine("Continue?");
                choice = Console.ReadLine();
            }

            string FirstName = "";
            string LastName = "";
            string DateOfBirth = "";
            Console.WriteLine("Welcome to registration form!");
            Console.WriteLine("Type your first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("type you last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("DOB?: ");
            DateOfBirth = Console.ReadLine();

            Console.WriteLine("Welocome, " + FirstName, " ", LastName, "Your registration is complete!");
            Console.WriteLine("Your temporary password is: "+FirstName+DateOfBirth);





        }
    }
}
