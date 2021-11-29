using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public bool HasDrowned { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Boat Type: {BoatType}\nDrowned?: {HasDrowned}";
        }
    }
}
