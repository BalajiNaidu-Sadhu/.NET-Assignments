using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsAssignment3.Constants;

namespace WindowsFormsAssignment3
{
    class Guild
    {
        readonly uint id;
        uint type;
        readonly string name, server;
        public Guild(uint id, uint type, string name, string server)
        {
            this.id = id;
            this.Type = type;
            this.name = name;
            this.server = server;
        }
        public uint Id { get { return id; } }
        public string Name { get { return name; } }
        public string Server { get { return server; } }
        public uint Type
        {
            get { return type; }
            set
            {
                if (value >= 0 && value < MAX_GUILDTYPES)
                    type = value;
            }
        }
    }
}
