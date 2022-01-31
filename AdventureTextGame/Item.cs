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


        //constructor
        public Item()
        {
            //default item when instance created; same as standard default item (?)
            name = "rubbish";
            description = "a pile of dirt and trash, why are you keeping this?";
        }
        
    }
}
