using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private double value;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userValue = textBox1.Text;
            value = Convert.ToDouble(userValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = (Math.Cos(value) + value + Math.Exp(value + 2) + Math.Log((3 * Math.Log(Math.Sqrt(2 * value + Math.Sin(value)))))) / Math.Exp(Math.Sin(value));

            textBox2.Text  = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
