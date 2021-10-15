using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    public class Car
    {
        public string Make;
        public string Year;
        public string Model;
        public string Color;
        public string CarType;

        public string GetCarInformation()
        {
            return String.Format($"Year: {Year}\n" +
                $"Make: {Make}\nModel: {Model}\n" +
                $"Color: {Color}\nCar Type: {CarType}");
        }

        public string GetCarInformation(bool lineBreak)
        {
            if (lineBreak)
            {
                return String.Format($"Year: {Year}\n" +
                    $"Make: {Make}\nModel: {Model}\n" +
                    $"Color: {Color}\nCar Type: {CarType}");
            }
            else
            {
                return String.Format($"Year: {Year}" +
                    $"Make: {Make}Model: {Model}" +
                    $"Color: {Color}Car Type: {CarType}");
            }
        }
    }
}
