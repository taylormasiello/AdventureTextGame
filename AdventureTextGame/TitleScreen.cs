using System;
using System.Collections.Generic;
using static System.Console;
using static AdventureTextGame.Item;

namespace AdventureTextGame
{
    public static class TitleScreen
    {
        public static string charName = "Hero";
        public static List<string> Inventory = new List<string>();
        //When player finds/interacts with items, can be added to this List as running inventory; will be displayed on end screen

        public static void gameStart()
        {
            Console.Title = "A Brave Hero's Adventure";
            // create a creative title screen

            WriteLine("A Brave Hero's Adventure");
            WriteLine("----------------------------------------------");
            WriteLine("Here in the Land of Heros, spelling is very important. \nOtherwise, it might be difficult to naviagte the journey.");
            WriteLine("----------------------------------------------");
            WriteLine("Finally, the hero we've been waiting for, with courage enough to embark on this great journey. Huzzah! \n(Press any key to continue)");
            ReadKey();
            
            //string plyrInput = ReadKey().ToString();

            //if (plyrInput == "Y" || plyrInput == "y")
            //{
            //    WriteLine("\nHuzzah!");
            //}
            //else if (plyrInput == "N" || plyrInput == "n")
            //{
            //    WriteLine("\nOh...pardon me traveler.");
            //}
            //else
            //{
            //    WriteLine("\nI don't understand, but I'll allow my optimism to interpret that as a hearty yes! Huzzah!");
            //}
            //WriteLine("----------------------------------------------");


        }

        public static void setCharName()
        {
            Console.Title = "A Journey Begins...";
            // changes title of console window; will be useful as player progresses through levels/chapters

            WriteLine("\nWhat is your name, so we may tell future tales of your adventure?");
            charName = ReadLine();
            WriteLine("\nWelcome! And a hearty cheers to " + charName + ", our new hero!");
            WriteLine("----------------------------------------------\n");

            //Consider using Console.Clear() to clear the screen. This helps separate parts of a text-heavy game (such as between levels, chapters, achievements, or when a player clicks enter at a title screen).
        }

        public static void firstStoryChoice()
        {
            string plyrInput;
            WriteLine(charName + ", are you a warrior of the sword? Or do you prefer to settle differences with your fists?\nType \"A\" to pick your sword from our blacksmith, or \"B\" to begin wrapping your hands and knuckles to protect yourself from your powerful blows.");
            plyrInput = ReadLine().ToUpper();

            if (plyrInput == "A")
            {
                WriteLine("\n'You hear bellowing laughter from whom you assume is the blacksmith.\' \"HAHAHA, A wise choice indeed! Surely no foe will be able to oppose you with this by your side.\" You are handed this sword, and it seems to instantly feel like a natural extension of your body. Was this created with you in mind?");
                WriteLine("----------------------------------------------\n");

                //creates new instance of Item class
                Item sword = new Item();
                sword.name = "Hero's sword";
                sword.description = "It feels as though this weapon was created with you in mind. When you hold\nthis sword, it's as if you've been weilding it all your life.";
                //adds new Item object to running Inventory List
                Inventory.Add(sword.name);
            }
            else //if the choice B (or anything else, think of as catch also, will trigger this choice)
            {
                WriteLine("You punch one hand into the other and let out a confident laugh. \"Thank you for the offer of steel, but I find my own body to be the best weapon.\" You can't help but notice the awe in the eyes of those who hear your confidence.");
                WriteLine("----------------------------------------------\n");
            }
        }

        public static void firstRandItem()
        {
            //creates new instance of RandItem class
            RandItem firstRandItem = new RandItem();
            WriteLine("Before you head out Hero, please, take this!\nYou are given a box with a mysterious item inside. You open the box and find a " + firstRandItem.name + "! (" + firstRandItem.description + ")");
            //adds new RandItem object to running Inventory List
            Inventory.Add(firstRandItem.name);
        }

        public static void lvlComplete()
        {
            WriteLine("\nYou look around and notice the optimism in the eyes of the people of this land. With a fire in your belly to finally being this next adventure, you leave this waystation, and start your joureny.");
            WriteLine("----------------------------------------------\n");
        }
    }
}

// The code below shows a scenario in which arguments aren't needed. A property of the Character class stores a number. A random number is compared to the stored value. If the stored value is greater than or equal to the random number, the result is true. Otherwise it is false.

// A narrative for this situation could be that as a player travels through the game there are opportunities for them to increase their "luck". The higher their luck, the better their chance is against "karma". A for loop is used in the example code below so you can see results that are both true and false.

//class Character
//{
//    static int luck = 5;
//    static Random randomNumber = new Random();
//    public static int points = 0;

//    public static bool Luck()
//    {

//        int karma = randomNumber.Next(10);
//        bool result = false;

//        if (luck >= karma)
//        { result = true; }

//        return result;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Console.Title = "Return Value Example";
//        Console.WriteLine("Your points: " + Character.points);
//        for (int i = 0; i < 20; i++)
//        {

//            if (Character.Luck())
//            {
//                Console.WriteLine("Your luck has gained you another point!");
//                Character.points++;
//            }
//            else
//            {
//                Console.WriteLine("Your luck has failed.... you've lost a point.");
//                Character.points--;
//            }
//        }
//        Console.WriteLine("Your points: " + Character.points);
//        Console.Read();
//    }