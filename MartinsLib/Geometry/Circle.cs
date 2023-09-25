using System;

namespace Shapes
{
    internal class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle()
        {
        }

        public double Radius { get => radius; set
            {
                if (value < 0)
                    radius = 10; // Set to 10 because of task requirements.
                else
                    radius = value;
            }
        }

        public double GetDiameter()
        {
            return Radius * 2;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            string s = "Circle: ";
            s += "Radius: " + Radius + ", ";
            s += "Diameter: " + GetDiameter () + ", ";
            s += "Area: " + GetArea() + ", ";
            s += "Circumference: " + GetCircumference();
            return s;
        }
        public string CustomizableToString(string opt)
        {
            opt = opt.ToLower();
            string s = "";
            if (opt.Contains("r"))
            {
                s += "Radius: " + Radius + "\n";
            }
            if (opt.Contains("d"))
            {
                s += "Diameter: " + GetDiameter() + "\n";
            }
            if (opt.Contains("a"))
            {
                s += "Area: " + GetArea() + "\n";
            }
            if (opt.Contains("c"))
            {
                s += "Circumference: " + GetCircumference() + "\n";
            }
            if (s == "")
            {
                s += "No options listed.\nPossible options are:\nR for Radius,\nD for Diameter,\nA for Area, \nC for Circumference";
            }
            return s;
        }
    }
}