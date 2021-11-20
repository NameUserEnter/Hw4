using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd2
{

    abstract class Figure
    {
        public abstract double determineArea();
        public abstract double determinePerimeter();

    }

    class CircleR : Figure
    {
        private double radius;

        public CircleR(double r)
        {
            radius = r;
        }
        public override double determineArea()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }
        public override double determinePerimeter()
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }
        public static bool checkSides(double r)
        {
            {
                if (r > 0)
                    return true;
                else
                    return false;
            }
        }
    }

    class DiamondR : Figure
    {
        private double side;
        private double angle;

        public DiamondR(double s, double ang)
        {
            side = s;
            angle = ang;
        }

        public override double determineArea()
        {
            return Math.Round(side * side * Math.Sin((Math.PI / 180) * angle), 2);
        }
        public override double determinePerimeter()
        {
            return 4 * side;
        }
        public static bool checkSides(double side, double ang)
        {
            {
                if (side > 0 && ang < 180 && ang > 0)
                    return true;
                else
                    return false;
            }
        }
    }

    class TriangleR : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public TriangleR(double a, double b, double c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
        }

        public static bool checkSides(double q, double w, double v)
        {
            if ((q > w + v) || (w > q + v) || (v > q + w) || v <= 0 || w <= 0 || q <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double determineArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)), 2);
        }
        public override double determinePerimeter()
        {
            return side1 + side2 + side3;
        }
    }

    class SquareR : Figure
    {
        private double side;

        public SquareR(double s)
        {
            side = s;
        }

        public override double determineArea()
        {
            return side * side;
        }
        public override double determinePerimeter()
        {
            return 4 * side;
        }
        public static bool checkSides(double s)
        {
            {
                if (s > 0)
                    return true;
                else
                    return false;
            }
        }
    }

    class RectangleR : Figure
    {
        private double side1;
        private double side2;

        public RectangleR(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        public static bool checkSquareSides(double q, double w)
        {
            if (q == w)
                return true;
            else
                return false;
        }
        public static bool checkSides(double s1, double s2)
        {
            {
                if (s1 > 0 && s2 > 0)
                    return true;
                else
                    return false;
            }
        }
        public override double determineArea()
        {
            return side1 * side2;
        }

        public override double determinePerimeter()
        {
            return 2 * (side1 + side2);
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
