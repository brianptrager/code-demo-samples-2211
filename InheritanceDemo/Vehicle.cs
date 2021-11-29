using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Vehicle
    {
        public double Value { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Year: {Year}\nColor: {Color}\nValue: {Value}\n";
        }
    }
}
