using System;
using static System.Console;

namespace AdventureTextGame
{
    public static class TitleScreen
    {
        static string charName = "Hero";

        public static void gameStart()
        {
            Console.Title = "A Brave Hero's Adventure";

            WriteLine("A Brave Hero's Adventure");
            WriteLine("----------------------------------------------");
            WriteLine("Are you the hero we've been waiting for, with courage enough to embark on this journey?");
            ReadKey();
            Console.Title = "A Journey Begins...";
            // changes title of console window; will be useful as player progresses through levels/chapters
        }

        public static void setCharName()
        {
            WriteLine("\nWhat is your name, so we may tell future tales of your adventure?");
            charName = ReadLine();
            WriteLine("\nWelcome! And a hearty cheers to " + charName + ", our new hero!");
            Console.Clear();

            //Consider using Console.Clear() to clear the screen. This helps separate parts of a text-heavy game (such as between levels, chapters, achievements, or when a player clicks enter at a title screen).
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