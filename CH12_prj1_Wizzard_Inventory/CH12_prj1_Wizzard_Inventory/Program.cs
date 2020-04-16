using System;
using System.Collections.Generic;

namespace CH12_prj1_Wizzard_Inventory {
    class Program {
       static  List<string> items = new List<string>();
        
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Wizzard Inventory\n");
            items.Add("Wooden Staff");
            items.Add("Wizzard Hat");
            items.Add("Cloth Shoes");

            string command = "";
            while (!command.Contains("exit")) {
                DisplayMenu();
                Console.Write("Command: ");
                command = Console.ReadLine();
                switch (command) {

                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
                Console.WriteLine();
            }
            
                                    

            Console.WriteLine("goodbye");
        }
       
        private static string FindItemByNumber() {
            string item = null;
            while (item ==null) {
                Console.Write("Item number: ");
                int itemNbr = 0;
                try {
                  itemNbr = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                item = items[itemNbr-1];
            }

            return item;
        }


        private static void DropItem() {
            string item = FindItemByNumber();
            //drop item
            items.Remove(item);
            Console.WriteLine(item + " was removed.\n");

        }

        private static void EditItem() {
            string item = FindItemByNumber();
            int idx = items.IndexOf(item);
            Console.WriteLine("Updated name: ");
            string updItem = Console.ReadLine();
            items[idx] = updItem;
            Console.WriteLine();

            //edit item
        }

        private static void GrabItem() {
            Console.WriteLine("Grab/Add an item name: ");
            if (items.Count>=4) {
                Console.WriteLine("Cannot add more items, please drop an item first.");
             } else {
                Console.WriteLine("Item name: ");
                string name = Console.ReadLine();
                items.Add(name);

            }
            Console.WriteLine();
        }

        private static void ShowItems() {
            Console.WriteLine("List of items: ");
           for (int i=0;i <items.Count;i++) {
                Console.WriteLine((i + 1) + ". " + items[i]);
            }
            Console.WriteLine();
        }

        static void DisplayMenu() {
            Console.WriteLine("COMMAND MENU:");
            Console.WriteLine("==========================");
            Console.WriteLine("show - show all items");
            Console.WriteLine("grab - grab/add an item");
            Console.WriteLine("edit - edit an item");
            Console.WriteLine("drop - drop an item");
            Console.WriteLine("exit - exit the app");
            Console.WriteLine();
        }
    }
}
