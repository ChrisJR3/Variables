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
            // Wayne Gretzky
            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            string.Pi = "3.14";
            string.r = "r";
            string.A = "A";
            // Not sure about this
            string.outputLabel.Text = Pi;
            string.outputLabel.Text = r;
            string.outputLabel.Text = A;
            string.exponent1 = ^2;
            int radius = 15;
            int radius/exponent = 225;
            int radius/exponent/Pi = 706.5;
            string.outputLabel.Text = A + " = " + Pi + r + exponent1;
            string.outputLabel.Text = n/A + " = " + Pi + radius + exponent1;
            string.outputLabel.Text = n / A + " = " + Pi + radius / exponent;
            string.outputLabel.Text = n / A + " = " + radius / exponent / Pi;
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
            Area
            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            string.cost1 = "Cost";
            int width1 = 8.5;
            int length1 = 6;
            int price1 = 19.95;
            int width1/length1 = 51;
            int width1/length1/price1 = 1017.45;
            string.outputLabel.Text = cost1 + " = " + price1 + "(" + width1 +'m' + " + " + length1 + "m)";
            string.outputLabel.Text = n/cost1 + " = " + price1 + width1/length1 + "m";
            string.outputLabel.Text = n/cost1 + " = " + width1/length1/price1;
            string.outputLabel.Text = n / "Therefore" + cost1 + "is" + width1/length1/price1;

            Thread.Sleep(5000);
            Clear = (Color.White);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Bill
        
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            string.change1 = "Change";
            string.money1 = "Money";
            string.price1 = "Price";
            string.taxes1 = "Taxes";
            string.preTaxes = "Original Cost";
            int.money2 = "20";
            int.price2 = "12.49";
            int.tax = "0.13";
            int.money/price = "7.51";
            int.actualTax = "1.62";
            int.pre-taxes = "10.87";
            string.outputLabel.Text = change1 + "=" + "$" + money1 + "-" + price1;
            string.outputLabel.Text = n / change1 + "=" + "$" + money2 + " - " + "$" + price2;
            string.outputLabel.Text = n / change1 + "=" + "$" + money/price;
            string.outputLabel.Text = n / ;
            string.outputLabel.Text = n / preTaxes + "=" + price1 + "-" + "($" + price1 + " x " + taxes1 + ")";
            string.outputLabel.Text = n / preTaxes + "=" + price2 + "-" + "($" + price2 + " x " + tax + ")";
            string.outputLabel.Text = n / preTaxes + "=" + price2 + "-" + actualTax;
            string.outputLabel.Text = n / preTaxes + "=" + pre-taxes;
            string.outputLabel.Text = n / "Therefore, the " + preTaxes + "is " + pre-taxes + ", and the " + change1 + "is " money/price + ".";
            
            Thread.Sleep(5000);
            Clear = (Color.White);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }
    }
}
