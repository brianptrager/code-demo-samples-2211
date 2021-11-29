using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Car : Vehicle
    {
        public string CarType { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Car Type: {CarType}";
        }
    }
}
