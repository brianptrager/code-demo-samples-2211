using System;
using System.Collections.Generic;

namespace SportsManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sport> sports = new List<Sport>();

            Player p = new Player();
            Coach c = new Coach();

            Team t = new Team("Tigers", new List<Player>(), new List<Coach>());

            sports.Add(new Sport(new List<Team>(), Sports.Baseball));



        }
    }
}
