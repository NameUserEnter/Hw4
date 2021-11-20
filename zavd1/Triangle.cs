using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace zavd1
{
    class Triangle
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double side_a, double side_b, double side_c)
        {
            try
            {
                Check_sides(side_a, side_b, side_c);
            }
            catch (Exception e) { MessageBox.Show("Sides are incorrect"); }
            a = side_a;
            b = side_b;
            c = side_c;

        }
        public bool Check_sides(double side_a, double side_b, double side_c)
        {
            if ((side_a <= 0) || (side_b <= 0) || (side_c <= 0) ||
                (side_a + side_b <= side_c) || (side_a + side_c <= side_b) || (side_c + side_b <= side_a))
            {
                return false;
            }
            else return true;
        }
        public bool ChangeSide(double side_a, double side_b, double side_c)
        {

            if (!Check_sides(side_a, side_b, side_c)) return false;
            a = side_a;
            b = side_b;
            c = side_c;
            return true;

        }
        public List<double> GetAngles()
        {
            List<double> angles = new List<double>();
            double angle_c = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            double angle_a = Math.Acos((c * c + b * b - a * a) / (2 * c * b));
            double angle_b = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            angles.Add(angle_a);
            angles.Add(angle_b);
            angles.Add(angle_c);
            return angles;
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public bool IsEquality()
        {
            return a == b && a == c && b == c;
        }
    }
    class EqulibriumTriangle : Triangle
    {
        public EqulibriumTriangle(double side_a, double side_b, double side_c) : base(side_a, side_b, side_c)
        {

        }
        public double Area()
        {
            return (a * a * Math.Sqrt(3)) / 4;
        }
    }
}

