using System;

namespace WizardInventory
{
    internal class Program
    {
        public static string[] items = { "wooden staff", "wizard hat", "cloth shoes", "" };
        static void Introduction()
        {
            Console.WriteLine("The Wizard Inventory program\n");
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit Program\n");
        }
        static void Main(string[] args)
        {
            string selection = "";
            Introduction();
            do
            {
                Console.Write("Command: ");
                selection = Console.ReadLine();
                if (selection == "show")
                {
                    Show();
                }
                else if (selection == "grab")
                {
                    Grab();
                }
                else if (selection == "edit")
                {
                    Edit();
                }
                else if (selection == "drop")
                {
                    Drop();
                }
                else if (selection == "exit")
                {
                    Console.WriteLine("Bye!");
                }
                else Console.WriteLine("Unknown Command\n");
            }
            while (selection != "exit");
        }
        static void Show()
        {
                string slot1 = "";
                string slot2 = "";
                string slot3 = "";
                string slot4 = "";
                for (int i = 0; i < items.Length; i++)
                    slot1 = "1. " + items[0];
                for (int i = 0; i < items.Length; i++)
                    slot2 = "2. " + items[1];
                for (int i = 0; i < items.Length; i++)
                    slot3 = "3. " + items[2];
                for (int i = 0; i < items.Length; i++)
                    slot4 = "4. " + items[3];
                if (items[0] != "")
                {
                    Console.WriteLine(slot1);
                }
                if (items[1] != "")
                {
                    Console.WriteLine(slot2);
                }
                if (items[2] != "")
                {
                    Console.WriteLine(slot3);
                }
                if (items[3] != "")
                {
                    Console.WriteLine(slot4);
                }
                Console.WriteLine();
        }

        static void Grab()
        {
                Console.Write("Name: ");
                string grabbedItem = Console.ReadLine();
                if (items[0] == "")
                {
                    items[0] = grabbedItem;
                Console.WriteLine(grabbedItem + " was added");
                }
                else if (items[1] == "")
                {
                    items[1] = grabbedItem;
                Console.WriteLine(grabbedItem + " was added");
                }
                else if (items[2] == "")
                {
                    items[2] = grabbedItem;
                Console.WriteLine(grabbedItem + " was added");
                }
                else if (items[3] == "")
                {
                    items[3] = grabbedItem;
                Console.WriteLine(grabbedItem + " was added");
                }
                else
                {
                    Console.WriteLine("You can't carry any more items. Drop something first.");
                }
        }
        static void Edit()
        {
            string numberSelection = "";
            do
            {
                Console.Write("Number: ");
                numberSelection = Console.ReadLine();
                Console.Write("Updated name: ");
                string updatedName = Console.ReadLine();
                if (numberSelection == "1")
                {
                    items[0] = updatedName;
                    Console.WriteLine("");
                }
                else if (numberSelection == "2")
                {
                    items[1] = updatedName;
                    Console.WriteLine("");
                }
                else if (numberSelection == "3")
                {
                    items[2] = updatedName;
                    Console.WriteLine("");
                }
                else if (numberSelection == "4")
                {
                    items[3] = updatedName;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Enter a number 1-4\n");
                }
            }
            while (Convert.ToInt32(numberSelection) <= 0 || Convert.ToInt32(numberSelection) >= 5);
        }
        static void Drop()
        {
            string numberSelection = "";
            do
            {
                Console.Write("Number: ");
                numberSelection = Console.ReadLine();
                if (numberSelection == "1")
                {
                    Console.WriteLine("Dropped " + items[0]);
                    Console.WriteLine();
                    items[0] = "";
                }
                else if (numberSelection == "2")
                {
                    Console.WriteLine("Dropped " + items[1]);
                    Console.WriteLine();
                    items[1] = "";
                }
                else if (numberSelection == "3")
                {
                    Console.WriteLine("Dropped " + items[2]);
                    Console.WriteLine();
                    items[2] = "";
                }
                else if (numberSelection == "4")
                {
                    Console.WriteLine("Dropped " + items[3]);
                    Console.WriteLine();
                    items[3] = "";
                }
                else
                {
                    Console.WriteLine("Enter a number 1-4\n");
                }
            }
            while (Convert.ToInt32(numberSelection) <= 0 || Convert.ToInt32(numberSelection) >= 5);
            if (items[0] == "")
            {
                items[0] = items[1];
                items[1] = "";
            }
            else if (items[1] == "")
            {
                items[1] = items[2];
                items[2] = "";
            }
            else if (items[2] == "")
            {
                items[2] = items[3];
                items[3] = "";
            }
        }
    }
}
