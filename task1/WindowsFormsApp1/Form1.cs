using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2= double.Parse(textBox2.Text);
            double result = 0;
            if (radioButton1.Checked == true)
            {
                result = n1 + n2;
            }

            else if (radioButton2.Checked == true)
            {
                result = n1 - n2;
            }
            else if (radioButton3.Checked == true)
            {
                result = n1 * n2;

            }
            else if (radioButton4.Checked == true)
            {
                result = n1 / n2;
            }

                textBox3.Text = result.ToString();
        }
    }
}
