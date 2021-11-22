using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagementSystem
{
    public enum Sports
    {
        Archery,
        Baseball,
        Basketball,
        Football,
        Soccer,
        Softball,
        Tennis
    }
    class Sport
    {
        public List<Team> Teams { get; set; }
        public int SportType { get; set; }

        public Sport()
        {
            Teams = new List<Team>();
            SportType = 0;
        }

        public Sport(List<Team> teams, Sports sport)
        {
            Teams = teams;
            SportType = (int) sport;
        }

        //ToString - add this when the class is ready for this.
    }
}
