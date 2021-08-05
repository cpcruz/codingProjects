using System;

namespace Coding_Project
{
    class Program

    {
        // restart class selection 
        static void startAgain()
        {
            classSelector();
        }
        
        static void classSelector()
        {
            //Class Selection
            Console.WriteLine("\nChoose a Class:\n\n1 - Barbarian\n2 - Bard\n3 - Cleric\n4 - Druid\n5 - Fighter\n6 - Monk\n7 - Paladin\n8 - Sorcerer\n9 - Wizard\n");
            //Class Select Input
            int classSelection;
            classSelection = Convert.ToInt32( Console.ReadLine() );
            //Class List
            string[] classes =
            {
                "null",
                "Barbarian",
                "Bard",
                "Cleric",
                "Druid",
                "Fighter",
                "Monk",
                "Paladin",
                "Sorcerer",
                "Wizard",
            };
            // confirmation 
            Console.WriteLine("You selected: " + classes[classSelection] + ".");
            Console.WriteLine("Confirm slection with 'Yes' or 'No'\n");  
            
            string answer = Console.ReadLine();

            if ( answer == "yes")
            {
                Console.WriteLine("\nWhat is this " + classes[classSelection] + "'s name?\n");
            }
            else
            {
               // back to the top
               startAgain();
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "D&D 5e Character Creator";

            classSelector();
            
            string playerName = Console.ReadLine();

            Console.WriteLine("\nYour hero's name is " + playerName + "?\n");
            
            string answer = Console.ReadLine();

        



            //Wait before closing
            Console.ReadKey();
        }
    }
}