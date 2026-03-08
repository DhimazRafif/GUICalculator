using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double angka1, angka2, hasil;
        string operasi;

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxOps.Text = textBoxOps.Text + "0";
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            operasi = "x";
            angka1 = double.Parse(textBoxOps.Text);
            textBoxOps.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operasi = "/";
            angka1 = double.Parse(textBoxOps.Text);
            textBoxOps.Clear();
        }

        private void buttonSD_Click(object sender, EventArgs e)
        {
            angka2 = double.Parse(textBoxOps.Text);
            switch (operasi)
            {
                case "+":
                    hasil = angka1 + angka2;
                    textBoxOps.Text=hasil.ToString();
                    break;
                case "-":
                    hasil = angka1 - angka2;
                    textBoxOps.Text=hasil.ToString(); 
                    break;
                case "x":
                    hasil = angka1 * angka2;
                    textBoxOps.Text = hasil.ToString();
                    break;
                case "/":
                    hasil = angka1 / angka2;
                    textBoxOps.Text = hasil.ToString();
                    break;
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxOps.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxOps.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operasi = "+";
            angka1 = double.Parse(textBoxOps.Text);
            textBoxOps.Clear();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            operasi = "-";
            angka1 = double.Parse(textBoxOps.Text);
            textBoxOps.Clear();
        }
    }
}
