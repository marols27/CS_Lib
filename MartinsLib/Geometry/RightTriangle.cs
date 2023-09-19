using System;

namespace Shapes
{
    internal class RightTriangle : Shape
    {
        private double width;
        private double height;

        public RightTriangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get => width; set
            {
                if (value < 0)
                    width = 10; // Set to 10 because of task requirement.
                else
                    width = value;
            }
        }
        public double Height
        {
            get => height; set
            {
                if (value < 0)
                    height = 10; // Set to 10 because of task requirement.
                else
                    height = value;
            }
        }

        public double GetHypotenuse()
        {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        }

        public double GetArea()
        {
            return Width * Height / 2;
        }

        public double GetCircumference()
        {
            return Width + Height + GetHypotenuse();
        }

        public override string ToString()
        {
            string s = "";
            s += "Width: " + Width + ", ";
            s += "Height: " + Height + ", ";
            s += "Area: " + GetArea() + ", ";
            s += "Circumference: " + GetCircumference() + ", ";
            s += "Hypotenuse: " + GetHypotenuse();
            return s;
        }

        public string ToString(string opt)
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
            if (opt.Contains("h"))
            {
                s += "Hypotenuse: " + GetHypotenuse() + "\n";
            }
            if (s == "")
            {
                s += "No options listed.\nPossible options are:\nW for Width,\nH for Height,\nA for Area,\nC for Circumference,\nH for Hypotenuse";
            }
            return s;
        }
    }
}
