using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePractical2
{
    class Alien
    {
        private string name;
        public string Name { 
            get
            {
                return name;
            }
            set 
            {
                if (value.Trim() == "")
                    name = "N/A";
                else
                    name = value;
            }
        }
        public string DateTime { get; set; }
        public string Location { get; set; }

        public Alien()
        {
            Name = "N/A";
            DateTime = "Not Provided";
            Location = "N/A";
        }

        public Alien(string name, string dt, string location)
        {
            Name = name;
            DateTime = dt;
            Location = location;
        }
    }
}
