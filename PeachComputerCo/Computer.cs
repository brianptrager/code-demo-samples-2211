using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeachComputerCo
{
    class Computer
    {
        public int RAMAmount { get; set; }
        public string OperatingSystem { get; set; }
        public string StorageType { get; set; }
        public string DeviceType { get; set; }

        public string Brand { get; set; }

        //Default constructor - this is a method with no parameters
        //that will be invoked when a new computer (object) is created
        public Computer()
        {
            RAMAmount = 0;
            OperatingSystem = "N/A";
            StorageType = "N/A";
            DeviceType = "N/A";
            Brand = "HP";
        }

        //A constructor with four parameters
        //It must be in the order defined
        public Computer(string os, string storage, string device, string brand, int ram = 4)
        {
            RAMAmount = ram;
            OperatingSystem = os;
            StorageType = storage;
            DeviceType = device;
            Brand = brand;
        }

        //ToString
        public override string ToString()
        {
            return $"RAM Amount: {RAMAmount}\n" +
                $"Operating System: {OperatingSystem}\n" +
                $"Storage Type: {StorageType}\n" +
                $"Device Type: {DeviceType}\n" +
                $"Brand: {Brand}\n" +
                $"Trade-in Value: {DetermineValue(Brand)}\n";
        }

        public static double DetermineValue(string brand)
        {
            if (brand == "Gateway")
                return 450;
            if (brand == "Dell")
            {
                return 670.23;
            }

            return 200;

        }

    }//end class


}
