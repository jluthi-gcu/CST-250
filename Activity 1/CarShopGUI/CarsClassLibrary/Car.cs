using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    public class Car
    {
        // list the properties
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }

        // Car constructor with 3 parameters
        public Car (string make, string model, decimal price, string color, int miles )
        {
            Make = make;
            Model = model;
            Price = price;
            Color = color;
            Miles = miles;
        }

        // Car constructor with 0 parameters. Provide default values.
        public Car()
        {
            Make = "Nothing yet";
            Model = "Nothing yet";
            Price = 0;
            Color = "Nothing yet";
            Miles = 0;
        }


        public override string ToString()
        {
            // Updated with custom fields.
            return string.Format("{0} {1} ${2} {3} {4}", Make, Model, Price, Color, Miles);
        }

    }
}
