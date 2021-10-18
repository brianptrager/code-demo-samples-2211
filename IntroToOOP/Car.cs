using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    public class Car
    {
        public string Make { get; set; }
        private int year;

        public int Year
        {
            get { return year; }
            set 
            {
                if (value >= 1900)
                    year = value;
                else
                    year = 1900;
            }
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public string CarType { get; set; }
        public decimal CarValue { get; set; }

        //public string Make;
        //public string Year;
        //public string Model;
        //private string color;
        //public string CarType;

        //public bool SetColor(string colorInput)
        //{
        //    if (colorInput.ToLower().Trim() == "black")
        //    {
        //        color = colorInput;
        //        return true;
        //    }
        //    return false;
        //}

        //public string GetColor()
        //{
        //    return color;
        //}

        public string GetCarInformation()
        {
            return String.Format($"Year: {year}\n" +
                $"Make: {Make}\nModel: {Model}\n" +
                $"Color: {Color}\nCar Type: {CarType}");
        }

        public string GetCarInformation(bool lineBreak)
        {
            if (lineBreak)
            {
                return String.Format($"Year: {year}\n" +
                    $"Make: {Make}\nModel: {Model}\n" +
                    $"Color: {Color}\nCar Type: {CarType}");
            }
            else
            {
                return String.Format($"Year: {year}" +
                    $"Make: {Make}Model: {Model}" +
                    $"Color: {Color}Car Type: {CarType}");
            }
        }
    }
}
