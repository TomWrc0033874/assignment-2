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
            double SRT;
            SRT = double.Parse(textBox1.Text);
            double S2RT;
            S2RT = double.Parse(textBox2.Text);
            double RT = SRT + S2RT;
            label1.Text = "SRT=" + SRT;
        }
    }
}
