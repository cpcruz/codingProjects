using System;

namespace Coding_Project
{

    class Barbarian
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Bard
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Cleric
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Druid
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Fighter
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Monk
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Paladin
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Sorcerer
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }
    class Wizard
    {
        public string name;
        public int age;
        public string favoriteWeapon;
        public float experience;
    }



    class Program

    {
        static void Main(string[] args)
        {
            Console.Title = "D&D 5e Character Creator";

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

            Console.ReadLine();

             Console.WriteLine("\nWhat is this " + classes[classSelection] + "'s name?\n");

            string playerName = Console.ReadLine();

            Console.WriteLine("\nYour hero's name is " + playerName + "?\n");
            string nameConfirm = Console.ReadLine();
            
        



            //Wait before closing
            Console.ReadKey();
        }
    }
}








