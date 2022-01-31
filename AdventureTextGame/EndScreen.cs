using System;
using static AdventureTextGame.TitleScreen;
using static System.Console;

namespace AdventureTextGame
{
    class EndScreen
    {
        public static void endGame()
        {
            WriteLine("Huzzah " + charName + ", you became the hero of the land!");
            WriteLine(charName + ", it's been a long and arduous journey, and you found some items along your way:");

            foreach (string item in Inventory)
            {
                WriteLine(item);
            }
            //writes out List of items/interactables the player found throughout game

            //see if a previously assigned objective given to the player was completed or not (for example, finding a diamond):
            //if (Inventory.Contains("diamond"))
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("Congratulations you completed your objective! You found the diamond!");
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.WriteLine("You didn't find the diamond... better luck next time!");
            //}


            WriteLine("\n" + charName + "...thank you for your courage and perserverance. Thanks to you, the land is once again at peace.\n(Thanks for playing! Press enter to end game.");
        }
    }
}
