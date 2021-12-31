using System;

namespace WizardInventory
{
    internal class Program
    {
        /*
         * Needs error handling
         */
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
                //Try using a switch statement
                //https://www.geeksforgeeks.org/switch-statement-in-c-sharp/
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
            //string slot1 = "";
            //string slot2 = "";
            //string slot3 = "";
            //string slot4 = "";
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] != "")
                {
                    Console.WriteLine(i + 1 + ". " + items[i]);
                }
            }
            //for (int i = 0; i < items.Length; i++)
            //    slot1 = "1. " + items[0];
            //for (int i = 0; i < items.Length; i++)
            //    slot2 = "2. " + items[1];
            //for (int i = 0; i < items.Length; i++)
            //    slot3 = "3. " + items[2];
            //for (int i = 0; i < items.Length; i++)
            //    slot4 = "4. " + items[3];
            //if (items[0] != "")
            //{
            //    Console.WriteLine(slot1);
            //}
            //if (items[1] != "")
            //{
            //    Console.WriteLine(slot2);
            //}
            //if (items[2] != "")
            //{
            //    Console.WriteLine(slot3);
            //}
            //if (items[3] != "")
            //{
            //    Console.WriteLine(slot4);
            //}
            Console.WriteLine();
        }

        static void Grab()
        {
            Console.Write("Name: ");
            string grabbedItem = Console.ReadLine();

            int index = -1;
            for(int i = 0; i < items.Length; i++)
            {
                //needs input validation for blankspace items
                if(items[i] == "")
                {
                    index = i;
                    break;
                }
            }

            if(index != -1)
            {
                items[index] = grabbedItem;
            }
            else
            {
                Console.WriteLine("You can't carry any more items. Drop something first.");
            }

            //if (items[0] == "")
            //{
            //    items[0] = grabbedItem;
            //Console.WriteLine(grabbedItem + " was added");
            //}
            //else if (items[1] == "")
            //{
            //    items[1] = grabbedItem;
            //Console.WriteLine(grabbedItem + " was added");
            //}
            //else if (items[2] == "")
            //{
            //    items[2] = grabbedItem;
            //Console.WriteLine(grabbedItem + " was added");
            //}
            //else if (items[3] == "")
            //{
            //    items[3] = grabbedItem;
            //Console.WriteLine(grabbedItem + " was added");
            //}
            //else
            //{
            //    Console.WriteLine("You can't carry any more items. Drop something first.");
            //}
        }
        static void Edit()
        {
            string numberSelection = "";
            int intNumberSelection = -1;
            do
            {
                Console.Write("Number: ");
                numberSelection = Console.ReadLine();
                intNumberSelection = Convert.ToInt32(numberSelection);
                Console.Write("Updated name: ");
                string updatedName = Console.ReadLine();

                if(intNumberSelection > 0 && intNumberSelection < 5)
                {
                    if(items[intNumberSelection-1] == "")
                    {
                        Console.WriteLine("Slot " + intNumberSelection + " is empty");
                    }
                    else
                    {
                        items[intNumberSelection - 1] = updatedName;
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number 1-4\n");
                }
                //if (numberSelection == "1")
                //{
                //    items[0] = updatedName;
                //    Console.WriteLine("");
                //}
                //else if (numberSelection == "2")
                //{
                //    items[1] = updatedName;
                //    Console.WriteLine("");
                //}
                //else if (numberSelection == "3")
                //{
                //    items[2] = updatedName;
                //    Console.WriteLine("");
                //}
                //else if (numberSelection == "4")
                //{
                //    items[3] = updatedName;
                //    Console.WriteLine("");
                //}
                //else
                //{
                //    Console.WriteLine("Enter a number 1-4\n");
                //}
            }
            while (intNumberSelection <= 0 || intNumberSelection >= 5);
        }
        static void Drop()
        {
            string numberSelection = "";
            int intNumberSelection = -1;
            do
            {
                Console.Write("Number: ");
                numberSelection = Console.ReadLine();
                intNumberSelection = Convert.ToInt32(numberSelection);
                if (intNumberSelection > 0 && intNumberSelection < 5)
                {
                    //can drop when item is blank. need to fix
                    items[intNumberSelection - 1] = "";
                }
                else
                {
                    Console.WriteLine("Enter a number 1-4\n");
                }
                //if (numberSelection == "1")
                //{
                //    Console.WriteLine("Dropped " + items[0]);
                //    Console.WriteLine();
                //    items[0] = "";
                //}
                //else if (numberSelection == "2")
                //{
                //    Console.WriteLine("Dropped " + items[1]);
                //    Console.WriteLine();
                //    items[1] = "";
                //}
                //else if (numberSelection == "3")
                //{
                //    Console.WriteLine("Dropped " + items[2]);
                //    Console.WriteLine();
                //    items[2] = "";
                //}
                //else if (numberSelection == "4")
                //{
                //    Console.WriteLine("Dropped " + items[3]);
                //    Console.WriteLine();
                //    items[3] = "";
                //}
                //else
                //{
                //    Console.WriteLine("Enter a number 1-4\n");
                //}
            }
            while (intNumberSelection <= 0 || intNumberSelection >= 5);



            if (items[0] == "")
            {
                items[0] = items[1];
                items[1] = "";
            }
            if (items[1] == "")
            {
                items[1] = items[2];
                items[2] = "";
            }
            if (items[2] == "")
            {
                items[2] = items[3];
                items[3] = "";
            }
        }
    }
}
