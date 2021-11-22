using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagementSystem
{
    class Player
    {
        public string Name { get; set; }
        public string Jersey { get; set; }
        public string Position { get; set; }

        public Player()
        {
            Name = "N/A";
            Jersey = "N/A";
            Position = "N/A";
        }

        public Player(string name, string jersey, string position)
        {
            Name = name;
            Jersey = jersey;
            Position = position;
        }

        //ToString add this when you know how to format the data
    }
}
