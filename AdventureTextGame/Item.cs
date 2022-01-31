using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTextGame
{
    public class Item
    {
        public string name;
        public string description;

        //string[] randomItems = { "shield", "flower", "blade of grass", "dead bug", "pebble" };
        //string[] randItmDescriptions = { 
        //    "Wooden and small, probably made for a child", 
        //    "Has a pleasant aroma, careful you don't sneezse", 
        //    "This seems useless", 
        //    "Gross, you really should clean out your rucksack more often", 
        //    "Smooth, could skip a few times if tossed on a pond" 
        //};

        //constructor
        public Item()
        {
            //default item when instance created; same as standard default item (?)
            name = "rubbish";
            description = "a pile of dirt and trash, why are you keeping this?";
        }
        
    }
}
