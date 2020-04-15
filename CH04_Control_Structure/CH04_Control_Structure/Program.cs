using System;

namespace CH04_Control_Structure {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the control structures app");

            // command menu example
            string command = "";
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("list - list all");
            Console.WriteLine("add -  add an item");
            Console.WriteLine("exit - exit loop");
            while (!command.Contains("exit")) {
                Console.Write("Enter a command: ");
                command = Console.ReadLine();
                switch (command) {
                    case "list":
                        Console.WriteLine("List selected");
                        break;
                    case "add":
                        Console.WriteLine("add selected");
                        break;
                    case "exit":
                        Console.WriteLine("exit selected");
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }


            }

            string[] names = { "Sarah", "Sam", "tyler", "jacob" };
            // in java for(type t: collection)
            foreach (string name in names) {
                Console.WriteLine(name);
                }
            Console.WriteLine("for loop");
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(names); //doesnt work

                Console.WriteLine("Goodbye");
            }
        }
    }

