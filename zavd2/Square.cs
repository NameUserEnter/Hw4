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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string side = text.Text;
                double a = double.Parse(side);
                if (SquareR.checkSides(a))
                {
                    SquareR square = new SquareR(a);
                    double per = square.determinePerimeter();
                    double area = square.determineArea();
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
