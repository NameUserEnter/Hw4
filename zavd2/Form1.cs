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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttontriangle.Checked == true)
            {
                this.Hide();

                Triangle form = new Triangle();
                form.Show();
            }
            if (buttoncircle.Checked == true)
            {
                this.Hide();

                Circle form = new Circle();
                form.Show();
            }
            if (buttondiamond.Checked == true)
            {
                this.Hide();

                Diamond form = new Diamond();
                form.Show();
            }
            if (buttonrectangle.Checked == true)
            {
                this.Hide();

                Rectangle form = new Rectangle();
                form.Show();
            }
            if (buttonsquare.Checked == true)
            {
                this.Hide();

                Square form = new Square();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
