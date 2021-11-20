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
    public partial class Diamond : Form
    {
        public Diamond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Side = side.Text;
                string Angle = angle.Text;
                double a = double.Parse(Side);
                double b = double.Parse(Angle);
                if(DiamondR.checkSides(a,b))
                {
                    DiamondR diamond = new DiamondR(a, b);
                    double per = diamond.determinePerimeter();
                    double area = diamond.determineArea();
                    MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);
                }
                else
                    MessageBox.Show("Incorrect format");
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
