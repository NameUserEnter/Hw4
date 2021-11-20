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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstbutton = FS.Text;
                string secondbutton = ss.Text;
                string thirdbutton = ts.Text;
                double q = double.Parse(firstbutton);
                double w = double.Parse(secondbutton);
                double v = double.Parse(thirdbutton);
                if (TriangleR.checkSides(q,w,v))
                {
                    MessageBox.Show("Sides are incorrect");
                }
                else
                {
                    TriangleR triangle = new TriangleR(q, w, v);
                    double per = triangle.determinePerimeter();
                    double area = triangle.determineArea();
                    MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);
                }
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
