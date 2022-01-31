using System;
using System.Collections.Generic;
using static System.Console;
using static AdventureTextGame.TitleScreen;

namespace AdventureTextGame
{
    class Chapter1
    {


        public static void choice()
        {
            Console.Title = "Chapter 1";

            int scenes = 1;
            //instead of hard-coding # of scenarios, can also do a multi-dimensionally array, putting the scenarios as an array, with each element an array of the string of responses for each choice

            string[] sceneOne = {
            "\nYou notice you're walking down a tan dirt path towards an open, grassy field. Before it on your right, you spot a rather large, oddly-shaped boulder.\nYou could just keep walking, after all that rock does look strange and nothing good ever comes from such things.\nOr perhaps it would be best to investigate? Maybe there's more than meets the eye.\n(Please type either A to investigate the boulder, or B to continue onward to the field.)\n----------------------------------------------\n",
            "\nDeep inside, you know you have to find out why this rock seems so off to you. You decided to walk over to the boulder.\nUpon further inspection, you realize the boulder is made out of some dirt covered, inked and filthy parchment. This isn't a boulder at all!\nYou lift the fake rock with ease, finding a key underneath.\nYou put both the key and the fake rock in your pocket, maybe it'll come in handy later?\nYou contiune onward to the field.",
            "\nYou decided to continue to the field. Let someone else bother with that boulder, you have adventure to find!\nYou laugh at yourself for thinking something so silly as a simple boulder possibly being special in some way.",
            "\nYou eventurally come upon a small, wooden fence with a gate door. The fence seems to stretch for a great distance in both directions.\nYou try to open the gated door, but it's locked.\n----------------------------------------------\n",
            "\nWelp, a locked gate door and a key from under a fake boulder not that far from each other. What are the chances?\nYou try the key in the lock, and success! Your attention to detail has allowed you to pass the barrier with ease.",
            "\nHuh. Maybe there was a key somewhere that you missed?\nWell what to do now? There's no way you have time to comb this whole field just for a key that likely isn't around anyway.\nRealizing that you are much taller than this barrier, you take a few steps back, and successfully bound over it.\nYou hit your tailbone on your way over, and wish you had somehow gotten lucky enough to find a key instead.",
            "\nWith your very first obstacle successfuly passed, you puff your chest out, and continue on your journey.\nIt won't be long until the bards write songs of you tales. You can hear it now,\n\"" + charName + ", the greatest Hero the land has ever seen!\"You start to see some hills off in the distance.\n----------------------------------------------\n"
        };
            //static string[] sceneTwo = {
            //    "Description of story part two ... and the choice A or B",
            //    "... part two - what happens if A is chosen...",
            //    "... part two - what happens if B is chosen...",
            //    "....more story.... .",
            //    "... part two, again - what happens if A is chosen...",
            //    "... part two again - what happens if B is chosen...",
            //    "You begin to climb the stairs to the next floor...."
            //};
            //static string[] sceneThree = {
            //    "Description of story part three... and the choice A or B",
            //    "... part 3 - what happens if A is chosen...",
            //    "... part 3 - what happens if B is chosen...",
            //    "....more story.... .",
            //    "... part 3, again - what happens if A is chosen...",
            //    "... part 3 again - what happens if B is chosen...",
            //    "You begin to climb the stairs to the next floor...."


            for (int section = 1; section <= scenes; section++)
            {
                string input = "";

                //write beginning of the scenario; ask for choice
                WriteLine(sceneOne[0]);
                WriteLine("Please enter your choice...");

                //read choice and save it as input variable
                input = ReadLine().ToUpper();

                //if choice A, print out the second element in choice array [1]
                if (input == "A")
                {
                    WriteLine(sceneOne[1]);
                    Inventory.Add("fake rock");
                    Inventory.Add("short fence gate key");
                }

                //if the choice B (or anything else, think of as catch also, will trigger this choice) prints fifth element in the array [2]
                else
                {
                    WriteLine(sceneOne[2]);
                }

                //next part of scenario; for both choice branches
                WriteLine(sceneOne[3]);

                //if choice was a, prints fifth element in the array [4]
                if (input == "a")
                {
                    WriteLine(sceneOne[4]);

                }
                else //if the choice B (or anything else, think of as catch also, will trigger this choice) prints sixth element in the array [5]
                {
                    WriteLine(sceneOne[5]);
                }

                //transition to the next part of the story; same for everyone
                WriteLine(sceneOne[6]);
            }


        }
    }
}
