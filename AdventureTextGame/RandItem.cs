using System;
using System.Collections.Generic;

namespace AdventureTextGame
{
    class RandItem : Item
    {
        string[] randomItems = { "shield", "flower", "blade of grass", "dead bug", "pebble" };
        string[] randItmDescriptions = {
            "Wooden and small, probably made for a child",
            "Has a pleasant aroma, careful you don't sneezse",
            "This seems useless",
            "Gross, you really should clean out your rucksack more often",
            "Smooth, could skip a few times if tossed on a pond"
        };

        public RandItem()
        {
            //Instantiate Random class 
            Random randomNumber = new Random();
            int number;

            //.Next(Int32) returns a non-negative random num less than the max (as stated in paren's) 
            number = randomNumber.Next(randomItems.Length);
            name = randomItems[number];
            description = randItmDescriptions[number];
        }

    }
}
