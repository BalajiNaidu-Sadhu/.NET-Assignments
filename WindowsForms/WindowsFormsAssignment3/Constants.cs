using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAssignment3
{
    class Constants
    {
        public enum Race { Orc, Troll, Tauren, Forsaken };
        public enum Classes
        {
            Warrior, Mage, Druid, Priest, Warlock,
            Rogue, Paladin, Hunter, Shaman
        }
        public enum Role { Tank, Healer, Damage };

        public static uint MAX_ILLVL = 360;
        public static uint MAX_PRIMARY = 200;
        public static uint MAX_STAMINA = 275;
        public static uint MAX_LEVEL = 60;
        public static uint MAX_GUILDTYPES = 5;
        public static uint MAX_INVENTORY_SIZE = 20;
        public static uint GEAR_SLOTS = 14; 
    }
}
