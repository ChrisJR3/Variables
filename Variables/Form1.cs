using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using.System.Media;
using System.Windows.Forms;
using System.Threading;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            string.firstName = "Wayne Gretzky";
            string.outputLabel.Text = firstName;
            int numberName = 99;
            string.outputLabel.Text = firstName + "is number" + numbername + ".";

            Thread.Sleep(5000);
            Clear = (Color.White);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            Pi = "3.14";
            r = "r";
            A = "A";
            string.outputLabel.Text = Pi;
            string.outputLabel.Text = r;
            string.outputLabel.Text = A;
            string.outputLabel.Text = ^2;
            int radius = 15;
            int radius/exponent = 225;
            int radius/Exponent/Pi = 706.5;
            string.outputLabel.Text = A + " = " + Pi + r + Exponent;
            string.outputLabel.Text = n/A + " = " + Pi + radius + Exponent;
            string.outputLabel.Text = n / A + " = " + Pi + radius / exponent;
            string.outputLabel.Text = n / A + " = " + radius / Exponent / Pi;
            string.outputLabel.Text = n / "Therefore" + A + "is 706.5.";

            Thread.Sleep(5000);
            Clear = (Color.White);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            firstName = "Wayne Gretzky";
            outputLabel.Text = firstName;
            int numberName = 99;
            outputLabel.Text = firstName + "is number" + numbername + ".";

            Thread.Sleep(5000);
            Clear = (Color.White);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            firstName = "Wayne Gretzky";
            outputLabel.Text = firstName;
            int numberName = 99;
            outputLabel.Text = firstName + "is number" + numbername + ".";

            Thread.Sleep(5000);
            Clear = (Color.White);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }
    }
}
