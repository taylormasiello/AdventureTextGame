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
        }
    }
}
