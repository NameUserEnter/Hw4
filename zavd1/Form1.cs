using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavd1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Triangle tr;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                if (a <= 0 || b <= 0 || c <= 0 || a >= b + c || b >= c + a || c >= a + b)
                {
                    MessageBox.Show("Sides are incorrect");
                }
                else
                {
                    tr = new Triangle(a, b, c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tr == null)
                {
                    MessageBox.Show("Sides are incorrect");
                }
                else
                {
                    List<double> angles = tr.GetAngles();
                    string line = "";
                    foreach (double an in angles)
                    {
                        line += an.ToString() + "   ";
                    }
                    textBox4.Text = line;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tr == null)
                {
                    MessageBox.Show("Sides are incorrect");
                }
                else
                {
                    textBox5.Text = tr.Perimeter().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tr == null||!tr.IsEquality())
                {
                    MessageBox.Show("Triangle Isn't Equality");
                }
                else
                {
                    EqulibriumTriangle tr1 = new EqulibriumTriangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                    textBox6.Text = tr1.Area().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
