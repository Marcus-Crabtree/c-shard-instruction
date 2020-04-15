using System;

namespace CH02__prj2_Grade_Converter {
    class Program {
        static void Main(string[] args) {
            int percentGrade = 0;
            string choice = "y";
            string letterGrade = "";
            Console.WriteLine("Welcome to the Letter Grade converter!");
            Console.WriteLine();
            while (choice.Contains("y")) {
                Console.WriteLine("enter numerical grade with max value of 100: ");
                percentGrade = Convert.ToInt32(Console.ReadLine());

                if (percentGrade >= 88)
                    letterGrade = "A";
                else if (percentGrade >= 80)
                    letterGrade = "B";
                else if (percentGrade >= 67)
                    letterGrade = "C";
                else if (percentGrade >= 60)
                    letterGrade = "D";
                else if (percentGrade < 60)
                    letterGrade = "F";

                Console.WriteLine("letter Grade: " + letterGrade);
                Console.WriteLine("press 'y' to continue or 'n' to exit: ");
                    choice = Console.ReadLine();

                                            
            }
            Console.WriteLine("goodbye!");

        }
    }
}
