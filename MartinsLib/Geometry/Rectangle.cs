using System;

namespace Shapes
{
    internal class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
        }

        public double Width
        {
            get => width; set
            {
                if (value < 0)
                    width = 10; // Set to 10 because of task requirements.
                else
                    width = value;
            }
        }

        public double Height { get => height; set
            {
                if (value < 0)
                    height = 10; // Set to 10 because of task requirements.
                else
                    height = value;
            }
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetCircumference()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            string s = "Rectangle: ";
            s += "Width: " + Width + ", ";
            s += "Height: " + Height + ", ";
            s += "Area: " + GetArea() + ", ";
            s += "Circumference: " + GetCircumference();
            return s;
        }

        public string CustomizableToString(string opt)
        {
            opt = opt.ToLower();
            string s = "";
            if (opt.Contains("w"))
            {
                s += "Width: " + Width + "\n";
            }
            if (opt.Contains("h"))
            {
                s += "Height: " + Height + "\n";
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
                s += "No options listed.\nPossible options are:\nW for Width,\nH for Height,\nA for Area,\nC for Circumference";
            }
            return s;
        }
    }
}