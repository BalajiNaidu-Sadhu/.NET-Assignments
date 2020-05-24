using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Constants
    {
        // Declaring ItemType by  enumeration.
        public enum ItemType                                                     
        {
            Helmet, Neck, Shoulders, Back, Chest,
            Wrist, Gloves, Belt, Pants, Boots,
            Ring, Trinket
        };

        // Declaring Race by  enumeration.
        public enum Race { Orc, Troll, Tauren, Forsaken };                      

        public enum Class
        {    
            Warrior,
            Mage,
            Druid,
            Priest,
            Warlock,
            Rogue,
            Paladin,
            Hunter,
            Shaman
        };
        public enum Role { Tank, DPS, Healer };
        public static uint MAX_ILLVL = 360;
        public static uint MAX_PRIMARY = 200;
        public static uint MAX_STAMINA = 275;
        public static uint MAX_LEVEL = 60;
        public static uint GEAR_SLOTS = 14;
        public static uint MAX_INVENTORY_SIZE = 20;

    }
}
