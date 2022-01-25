using System;
using static System.Console;


namespace AdventureTextGame
{
    class Program
    {
        static void Main()
        {
            string charName = "Hero";

            WriteLine("A Brave Hero's Adventure");
            WriteLine("----------------------------------------------");
            WriteLine("Are you the hero we've been waiting for, with courage enough to embark on this journey?");
            WriteLine("\nWhat is your name, so we may tell future tales of your adventure?");

            charName = ReadLine();

            WriteLine("\nWelcome! And a hearty cheers to " + charName + ", our new hero!");
        }
    }
}
