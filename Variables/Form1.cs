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
            string.firstName = "Wayne Gretzky";
            string.outputLabel.Text = firstName;
            int numberName = 99;
            string.outputLabel.Text = firstName + "is number" + numbername + ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string.Pi = "3.14";
            string.r = "r";
            string.A = "A";
            string.exponent1 = ^2;
            int radius = 15;
            int exponent = 15;
            int radiusExponent = radius * exponent;
            int radiusExponentPi = radiusExponent * Pi;
            string.outputLabel.Text = A + " = " + Pi + " x " r + exponent1;
            string.outputLabel.Text += "n/" + A + " = " + Pi + " x " + radius + exponent1;
            string.outputLabel.Text += "n/" + A + " = " + Pi + " x " + radiusExponent;
            string.outputLabel.Text += "n/" + A + " = " + radiusExponentPi;
            string.outputLabel.Text += "n/" + "Therefore" + A + "is " + radiusExponentPi + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string.cost1 = "Cost";
            double width1 = 8.5;
            int length1 = 6;
            double price1 = 19.95;
            double width1length1 = width1 * length1;
            double width1length1price1 = width1length1 * price1;
            string.outputLabel.Text = cost1 + " = " + price1 + "(" + width1 +'m' + " x " + length1 + "m)";
            string.outputLabel.Text = "n/" + cost1 + " = " + price1 + " x " + width1length1 + "m";
            string.outputLabel.Text = "n/" + cost1 + " = " + width1length1price1;
            string.outputLabel.Text = "n/" + "Therefore" + cost1 + "is" + width1/length1/price1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string.change1 = "Change";
            string.money1 = "Money";
            string.price1 = "Price";
            string.taxes1 = "Taxes";
            string.preTaxes = "Original Cost";
            int.money2 = "20";
            double.price2 = "12.49";
            double.tax = "0.13";
            double.moneyPrice = money2 - price2;
            double.actualTax = price2 * tax;
            double.preTax = price2 - actualTax;
            string.outputLabel.Text = change1 + "=" + "$" + money1 + "-" + price1;
            string.outputLabel.Text = "n/" + change1 + "=" + "$" + money2 + " - " + "$" + price2;
            string.outputLabel.Text = "n/" + change1 + "=" + "$" + moneyPrice;
            string.outputLabel.Text = "n/";
            string.outputLabel.Text = "n/" + preTaxes + "=" + price1 + "-" + "($" + price1 + " x " + taxes1 + ")";
            string.outputLabel.Text = "n/" + preTaxes + "=" + price2 + "-" + "($" + price2 + " x " + tax + ")";
            string.outputLabel.Text = "n/" + preTaxes + "=" + price2 + "-" + actualTax;
            string.outputLabel.Text = "n/" + preTaxes + "=" + preTax;
            string.outputLabel.Text = "n/" + "Therefore, the " + preTaxes + "is " + preTax + ", and the " + change1 + "is " moneyPrice + ".";
        }
    }
}
