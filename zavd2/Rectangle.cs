using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd2
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstbutton = FS.Text;
                string secondbutton = ss.Text;
                double a = double.Parse(firstbutton);
                double b = double.Parse(secondbutton);
                if (RectangleR.checkSides(a, b))
                {
                    RectangleR rectangle = new RectangleR(a, b);
                    double per = rectangle.determinePerimeter();
                    double area = rectangle.determineArea();
                    if (RectangleR.checkSquareSides(a, b))
                        MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area + "\n" + "Square");
                    else
                        MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);
                }
                else
                    MessageBox.Show("Sides are incorrect");
                this.Hide();

                Form1 change = new Form1();
                change.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
