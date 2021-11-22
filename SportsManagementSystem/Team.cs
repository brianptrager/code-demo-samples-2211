using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagementSystem
{
    class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public List<Coach> Coaches { get; set; }

        public Team()
        {
            Name = "N/A";
            Players = new List<Player>();
            Coaches = new List<Coach>();
        }

        public Team(string name, List<Player> players, List<Coach> coaches)
        {
            Name = "N/A";
            Players = players;
            Coaches = coaches;
        }
    }
}
