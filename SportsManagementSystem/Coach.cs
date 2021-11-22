using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagementSystem
{
    class Coach
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Coach()
        {
            Name = "N/A";
            Position = "N/A";
        }

        public Coach(string name, string position)
        {
            Name = name;
            Position = position;
        }

        //ToString when you're ready
    }
}
