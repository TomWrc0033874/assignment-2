using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double S1RT;
            try
            {
                S1RT = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                S1RT = 0.0;
            }
            double S2RT;
            try
            {
                S2RT = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                S2RT = 0.0;

            }
            double SRT = S1RT + S2RT;
            label1.Text = " SRT =" + SRT;
            //This is the series circuit that calculates 2 resistors
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double S3RT;
            try
            {
                S3RT = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                S3RT = 0.0;
            }
            double S4RT;
            try
            {
                S4RT = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                S4RT = 0.0;

            }
            double S5RT;
            try
            {
                S5RT = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                S5RT = 0.0;
            }
            double SRT = S3RT + S4RT + S5RT;
            label5.Text = " SRT =" + SRT;
            //This is the series circuit that calculates 3 resistors
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double P1RT;
            try
            {
                P1RT = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                P1RT = 0.0;
            }
            double P2RT;
            try
            {
                P2RT = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                P2RT = 0.0;

            }
            double PRT = 1.0 / (1.0 / P1RT + 1.0 / P2RT);
            label3.Text = " PRT =" + PRT;
                
             
            //This is the parallel circuit that calculates 2 resistors
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double P3RT;
            try
            {
                P3RT = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                P3RT = 0.0;
            }
            double P4RT;
            try
            {
                P4RT = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value");
                P4RT = 0.0;

            }
            double P5RT;
            try
            {
                P5RT = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("Ivalid value");
                P5RT = 0.0;
            }
            double PRT = 1.0 / (1.0 / P3RT + 1.0 / P4RT + 1.0 / P5RT);
            label8.Text = " PRT =" + PRT;
        }
    }
    
}
